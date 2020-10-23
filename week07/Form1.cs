using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week07.Entities;

namespace week07
{

    public partial class Form1 : Form
    {
        List<Person> Population = new List<Person>();
        List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
        List<DeathProbability> DeathProbabilities = new List<DeathProbability>();
        public Form1()
        {
            InitializeComponent();
            Population = GetPopulation(@"C:\Windows\Temp\nép.csv");
            BirthProbabilities = GetBirthProbabilities(@"C:\Windows\Temp\születés.csv");
            DeathProbabilities = GetDeathProbabilities(@"C:\Windows\Temp\halál.csv");


            
        }

        private void Simulation(int zaroev)
        {
            for (int year = 2005; year <= 2024; year++)
            {
                // Végigmegyünk az összes személyen
                for (int i = 0; i < Population.Count; i++)
                {
                    Random rng = new Random(1234);
                    Person person = Population[i];
                    //Ha halott akkor kihagyjuk, ugrunk a ciklus következő lépésére
                    if (!person.IsAlive) return;

                    // Letároljuk az életkort, hogy ne kelljen mindenhol újraszámolni
                    byte age = (byte)(year - person.BirthYear);

                    // Halál kezelése
                    // Halálozási valószínűség kikeresése
                    double pDeath = (from x in DeathProbabilities
                                     where x.Gender == person.Gender && x.Age == age
                                     select x.DeathProb).FirstOrDefault();
                    // Meghal a személy?
                    if (rng.NextDouble() <= pDeath)
                        person.IsAlive = false;

                    //Születés kezelése - csak az élő nők szülnek
                    if (person.IsAlive && person.Gender == Gender.Female)
                    {
                        //Szülési valószínűség kikeresése
                        double pBirth = (from x in BirthProbabilities
                                         where x.Age == age
                                         select x.BirthProb).FirstOrDefault();
                        //Születik gyermek?
                        if (rng.NextDouble() <= pBirth)
                        {
                            Person újszülött = new Person();
                            újszülött.BirthYear = year;
                            újszülött.NbrOfChildren = 0;
                            újszülött.Gender = (Gender)(rng.Next(1, 3));
                            Population.Add(újszülött);
                        }
                    }
                }

                int nbrOfMales = (from x in Population
                                  where x.Gender == Gender.Male && x.IsAlive
                                  select x).Count();
                int nbrOfFemales = (from x in Population
                                    where x.Gender == Gender.Female && x.IsAlive
                                    select x).Count();
                //Console.WriteLine(
                // string.Format("Év:{0} Fiúk:{1} Lányok:{2}", year, nbrOfMales, nbrOfFemales));
                eredmenytxt.Text = eredmenytxt.Text + string.Format("Szimulációs év:{0}" + Environment.NewLine + "\t" + " Fiuk:{1}" + Environment.NewLine + "\t" + " Lányok:{2}" + Environment.NewLine, year, nbrOfMales, nbrOfFemales);
            }
        }

        public List<Person> GetPopulation(string csvpath)
        {
            List<Person> population = new List<Person>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    population.Add(new Person()
                    {
                        BirthYear = int.Parse(line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        NbrOfChildren = int.Parse(line[2])
                    });
                }
            }

            return population;
        }
        public List<BirthProbability> GetBirthProbabilities(string csvpath)
        {
            List<BirthProbability> BirthProbs = new List<BirthProbability>();
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    BirthProbs.Add(new BirthProbability()
                    {
                        Age = int.Parse(line[0]),
                        NbrOfChildren = int.Parse(line[1]),
                        BirthProb = double.Parse(line[2])

                    });
                }
            }
            return BirthProbs;
        }
        public List<DeathProbability> GetDeathProbabilities(string csvpath)
        {
            List<DeathProbability> DeathProbs = new List<DeathProbability>();
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    DeathProbs.Add(new DeathProbability()
                    {
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[0]),
                        Age = int.Parse(line[1]),
                        DeathProb = double.Parse(line[2])

                    });
                }
            }
            return DeathProbs;
        }

        private void SimStep(int year, Person person)
        {
            Random rng = new Random(1234);
            //Ha halott akkor kihagyjuk, ugrunk a ciklus következő lépésére
            if (!person.IsAlive) return;

            // Letároljuk az életkort, hogy ne kelljen mindenhol újraszámolni
            byte age = (byte)(year - person.BirthYear);

            // Halál kezelése
            // Halálozási valószínűség kikeresése
            double pDeath = (from x in DeathProbabilities
                             where x.Gender == person.Gender && x.Age == age
                             select x.DeathProb).FirstOrDefault();
            // Meghal a személy?
            if (rng.NextDouble() <= pDeath)
                person.IsAlive = false;

            //Születés kezelése - csak az élő nők szülnek
            if (person.IsAlive && person.Gender == Gender.Female)
            {
                //Szülési valószínűség kikeresése
                double pBirth = (from x in BirthProbabilities
                                 where x.Age == age
                                 select x.BirthProb).FirstOrDefault();
                //Születik gyermek?
                if (rng.NextDouble() <= pBirth)
                {
                    Person újszülött = new Person();
                    újszülött.BirthYear = year;
                    újszülött.NbrOfChildren = 0;
                    újszülött.Gender = (Gender)(rng.Next(1, 3));
                    Population.Add(újszülött);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                csvpathtxt.Text = choofdlog.FileName.ToString();

            }
            Population = GetPopulation(choofdlog.FileName);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            eredmenytxt.Text = "";
            Simulation(int.Parse(zaroev.Value.ToString()) + 1);
        }
    }
}
