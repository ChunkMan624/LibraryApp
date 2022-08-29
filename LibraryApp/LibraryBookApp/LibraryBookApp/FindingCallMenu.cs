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

namespace LibraryBookApp
{
    public partial class FindingCallMenu : Form
    {
        Tree<string> tree = new Tree<string>();
        public List<string> levlFir = new List<string>();
        public static List<UserStored> userDets = new List<UserStored>();
        public List<string> levlSec = new List<string>();
        public List<string> levlThir = new List<string>();
        public List<string> opts = new List<string>();
        static List<string> ans = new List<string>();

        int selectFirst;
        int selectSecond;
        int selectThird;
        int roundNo = 0;
        int optsCount = 0;
        int score = 0;

        public FindingCallMenu()
        {
            InitializeComponent();
        }

        private void btnOptSec_Click(object sender, EventArgs e)
        {
            switch (roundNo)
            {
                case 1:
                    if (opts.ElementAt(1) == ans.ElementAt(0))
                    {
                        MessageBox.Show("This answer was correct", "Congratulations");
                        score++;
                        ClearText();
                        SelectOptionsSecond();
                    }
                    else
                    {
                        MessageBox.Show("This answer was incorrect", "Oops");
                        ClearText();
                        SelectOptionsSecond();
                    }
                    break;
                case 2:
                    if (opts.ElementAt(1) == ans.ElementAt(1))
                    {
                        MessageBox.Show("This answer was correct", "Congratulations");
                        score++;
                        ClearText();
                        SelectOptionsThird();
                    }
                    else
                    {
                        MessageBox.Show("This answer was incorrect", "Oops");
                        ClearText();
                        SelectOptionsThird();
                    }
                    break;
                case 3:
                    if (opts.ElementAt(1) == ans.ElementAt(2))
                    {
                        MessageBox.Show("This answer was correct", "Congratulations");
                        score++;
                        ApplyScore();
                        ClearText();
                        btnStart.Enabled = true;
                        btnLead.Enabled = true;
                        btnEnd.Enabled = false;
                        btnBack.Enabled = true;
                        btnOptFir.Enabled = false;
                        btnOptSec.Enabled = false;
                        btnOptThir.Enabled = false;
                        btnOptFor.Enabled = false;
                        ans.Clear();
                        opts.Clear();
                        optsCount = 0;
                        txbClue.Clear();
                    }
                    else
                    {
                        MessageBox.Show("This answer was incorrect", "Oops");
                        ApplyScore();
                        ClearText();
                        btnStart.Enabled = true;
                        btnLead.Enabled = true;
                        btnEnd.Enabled = false;
                        btnBack.Enabled = true;
                        btnOptFir.Enabled = false;
                        btnOptSec.Enabled = false;
                        btnOptThir.Enabled = false;
                        btnOptFor.Enabled = false;
                        ans.Clear();
                        opts.Clear();
                        optsCount = 0;
                        txbClue.Clear();
                    }
                    break;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ans.Clear();
            btnBack.Enabled = false;
            btnLead.Enabled = false;
            btnStart.Enabled = false;
            btnEnd.Enabled = true;
            btnOptFir.Enabled = true;
            btnOptSec.Enabled = true;
            btnOptThir.Enabled = true;
            btnOptFor.Enabled = true;
            PopulateLists();
            CreateTree();
            SelectAns();
            SelectOptionsFirst();
            PopulateClue();
        }

        public void PopulateLists()
        {
            int counter = 0;

            //Calls the first level of call numbers from the text file to the list
            StreamReader callRead = new StreamReader(@"C:\Users\User\Desktop\18002919_PROG7312_POE\LibraryBookApp\LibraryBookApp\CallNums.txt");

            while(callRead.ReadLine() != null)
            {
                if(counter < 10)
                {
                    string line1 = callRead.ReadLine();
                    string line2 = callRead.ReadLine();
                    string dataVal = ("" + line1 + " " + line2);
                    levlFir.Add(dataVal);
                    counter++;
                }
                else if(counter >= 10 && counter < 50)
                {
                    string line1 = callRead.ReadLine();
                    string line2 = callRead.ReadLine();
                    string dataVal = ("" + line1 + " " + line2);
                    levlSec.Add(dataVal);
                    counter++;
                }
                else if(counter >= 50)
                {
                    string line1 = callRead.ReadLine();
                    string line2 = callRead.ReadLine();
                    string dataVal = ("" + line1 + " " + line2);
                    levlThir.Add(dataVal);
                    counter++;
                }
            }
            callRead.Close();
        }

        public void PopulateClue()
        {
            string clue = tree.Root.Children[selectFirst].Children[selectSecond].Children[selectThird].Data;
            txbClue.Text = clue.Remove(0, 4);
        }

        public void CreateTree()
        {
            
            tree.Root = new TreeNode<string>() { Data = "Calls" };

            tree.Root.Children = new List<TreeNode<string>>
            {
                new TreeNode<string>() { Data = levlFir.ElementAt(0), Parent = tree.Root},
                new TreeNode<string>() { Data = levlFir.ElementAt(1), Parent = tree.Root},
                new TreeNode<string>() { Data = levlFir.ElementAt(2), Parent = tree.Root},
                new TreeNode<string>() { Data = levlFir.ElementAt(3), Parent = tree.Root},
                new TreeNode<string>() { Data = levlFir.ElementAt(4), Parent = tree.Root},
                new TreeNode<string>() { Data = levlFir.ElementAt(5), Parent = tree.Root},
                new TreeNode<string>() { Data = levlFir.ElementAt(6), Parent = tree.Root},
                new TreeNode<string>() { Data = levlFir.ElementAt(7), Parent = tree.Root},
                new TreeNode<string>() { Data = levlFir.ElementAt(8), Parent = tree.Root},
                new TreeNode<string>() { Data = levlFir.ElementAt(9), Parent = tree.Root}
            };


            tree.Root.Children[0].Children = new List<TreeNode<string>>
            {
                new TreeNode<string>() { Data = levlSec.ElementAt(0), Parent = tree.Root.Children[0] },
                new TreeNode<string>() { Data = levlSec.ElementAt(1), Parent = tree.Root.Children[0] },
                new TreeNode<string>() { Data = levlSec.ElementAt(2), Parent = tree.Root.Children[0] },
                new TreeNode<string>() { Data = levlSec.ElementAt(3), Parent = tree.Root.Children[0] }
            };
            tree.Root.Children[1].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlSec.ElementAt(4), Parent = tree.Root.Children[1] },
                new TreeNode<string>() { Data = levlSec.ElementAt(5), Parent = tree.Root.Children[1] },
                new TreeNode<string>() { Data = levlSec.ElementAt(6), Parent = tree.Root.Children[1] },
                new TreeNode<string>() { Data = levlSec.ElementAt(7), Parent = tree.Root.Children[1] }
            };
            tree.Root.Children[2].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlSec.ElementAt(8), Parent = tree.Root.Children[2] },
                new TreeNode<string>() { Data = levlSec.ElementAt(9), Parent = tree.Root.Children[2] },
                new TreeNode<string>() { Data = levlSec.ElementAt(10), Parent = tree.Root.Children[2] },
                new TreeNode<string>() { Data = levlSec.ElementAt(11), Parent = tree.Root.Children[2] }
            };
            tree.Root.Children[3].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlSec.ElementAt(12), Parent = tree.Root.Children[3] },
                new TreeNode<string>() { Data = levlSec.ElementAt(13), Parent = tree.Root.Children[3] },
                new TreeNode<string>() { Data = levlSec.ElementAt(14), Parent = tree.Root.Children[3] },
                new TreeNode<string>() { Data = levlSec.ElementAt(15), Parent = tree.Root.Children[3] }
            };
            tree.Root.Children[4].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlSec.ElementAt(16), Parent = tree.Root.Children[4] },
                new TreeNode<string>() { Data = levlSec.ElementAt(17), Parent = tree.Root.Children[4] },
                new TreeNode<string>() { Data = levlSec.ElementAt(18), Parent = tree.Root.Children[4] },
                new TreeNode<string>() { Data = levlSec.ElementAt(19), Parent = tree.Root.Children[4] }
            };
            tree.Root.Children[5].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlSec.ElementAt(20), Parent = tree.Root.Children[5] },
                new TreeNode<string>() { Data = levlSec.ElementAt(21), Parent = tree.Root.Children[5] },
                new TreeNode<string>() { Data = levlSec.ElementAt(22), Parent = tree.Root.Children[5] },
                new TreeNode<string>() { Data = levlSec.ElementAt(23), Parent = tree.Root.Children[5] }
            };
            tree.Root.Children[6].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlSec.ElementAt(24), Parent = tree.Root.Children[6] },
                new TreeNode<string>() { Data = levlSec.ElementAt(25), Parent = tree.Root.Children[6] },
                new TreeNode<string>() { Data = levlSec.ElementAt(26), Parent = tree.Root.Children[6] },
                new TreeNode<string>() { Data = levlSec.ElementAt(27), Parent = tree.Root.Children[6] }
            };
            tree.Root.Children[7].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlSec.ElementAt(28), Parent = tree.Root.Children[7] },
                new TreeNode<string>() { Data = levlSec.ElementAt(29), Parent = tree.Root.Children[7] },
                new TreeNode<string>() { Data = levlSec.ElementAt(30), Parent = tree.Root.Children[7] },
                new TreeNode<string>() { Data = levlSec.ElementAt(31), Parent = tree.Root.Children[7] }
            };
            tree.Root.Children[8].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlSec.ElementAt(32), Parent = tree.Root.Children[8] },
                new TreeNode<string>() { Data = levlSec.ElementAt(33), Parent = tree.Root.Children[8] },
                new TreeNode<string>() { Data = levlSec.ElementAt(34), Parent = tree.Root.Children[8] },
                new TreeNode<string>() { Data = levlSec.ElementAt(35), Parent = tree.Root.Children[8] }
            };
            tree.Root.Children[9].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlSec.ElementAt(36), Parent = tree.Root.Children[9] },
                new TreeNode<string>() { Data = levlSec.ElementAt(37), Parent = tree.Root.Children[9] },
                new TreeNode<string>() { Data = levlSec.ElementAt(38), Parent = tree.Root.Children[9] },
                new TreeNode<string>() { Data = levlSec.ElementAt(39), Parent = tree.Root.Children[9] }
            };


            tree.Root.Children[0].Children[0].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(0), Parent = tree.Root.Children[0].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(1), Parent = tree.Root.Children[0].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(2), Parent = tree.Root.Children[0].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(3), Parent = tree.Root.Children[0].Children[0] }
            };
            tree.Root.Children[0].Children[1].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(4), Parent = tree.Root.Children[0].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(5), Parent = tree.Root.Children[0].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(6), Parent = tree.Root.Children[0].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(7), Parent = tree.Root.Children[0].Children[1] }
            };
            tree.Root.Children[0].Children[2].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(8), Parent = tree.Root.Children[0].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(9), Parent = tree.Root.Children[0].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(10), Parent = tree.Root.Children[0].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(11), Parent = tree.Root.Children[0].Children[2] }
            };
            tree.Root.Children[0].Children[3].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(12), Parent = tree.Root.Children[0].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(13), Parent = tree.Root.Children[0].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(14), Parent = tree.Root.Children[0].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(15), Parent = tree.Root.Children[0].Children[3] }
            };

            tree.Root.Children[1].Children[0].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(16), Parent = tree.Root.Children[1].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(17), Parent = tree.Root.Children[1].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(18), Parent = tree.Root.Children[1].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(19), Parent = tree.Root.Children[1].Children[0] }
            };
            tree.Root.Children[1].Children[1].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(20), Parent = tree.Root.Children[1].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(21), Parent = tree.Root.Children[1].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(22), Parent = tree.Root.Children[1].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(23), Parent = tree.Root.Children[1].Children[1] }
            };
            tree.Root.Children[1].Children[2].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(24), Parent = tree.Root.Children[1].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(25), Parent = tree.Root.Children[1].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(26), Parent = tree.Root.Children[1].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(27), Parent = tree.Root.Children[1].Children[2] }
            };
            tree.Root.Children[1].Children[3].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(28), Parent = tree.Root.Children[1].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(29), Parent = tree.Root.Children[1].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(30), Parent = tree.Root.Children[1].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(31), Parent = tree.Root.Children[1].Children[3] }
            };

            tree.Root.Children[2].Children[0].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(32), Parent = tree.Root.Children[2].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(33), Parent = tree.Root.Children[2].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(34), Parent = tree.Root.Children[2].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(35), Parent = tree.Root.Children[2].Children[0] }
            };
            tree.Root.Children[2].Children[1].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(36), Parent = tree.Root.Children[2].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(37), Parent = tree.Root.Children[2].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(38), Parent = tree.Root.Children[2].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(39), Parent = tree.Root.Children[2].Children[1] }
            };
            tree.Root.Children[2].Children[2].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(40), Parent = tree.Root.Children[2].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(41), Parent = tree.Root.Children[2].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(42), Parent = tree.Root.Children[2].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(43), Parent = tree.Root.Children[2].Children[2] }
            };
            tree.Root.Children[2].Children[3].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(44), Parent = tree.Root.Children[2].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(45), Parent = tree.Root.Children[2].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(46), Parent = tree.Root.Children[2].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(47), Parent = tree.Root.Children[2].Children[3] }
            };

            tree.Root.Children[3].Children[0].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(48), Parent = tree.Root.Children[3].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(49), Parent = tree.Root.Children[3].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(50), Parent = tree.Root.Children[3].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(51), Parent = tree.Root.Children[3].Children[0] }
            };
            tree.Root.Children[3].Children[1].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(52), Parent = tree.Root.Children[3].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(53), Parent = tree.Root.Children[3].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(54), Parent = tree.Root.Children[3].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(55), Parent = tree.Root.Children[3].Children[1] }
            };
            tree.Root.Children[3].Children[2].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(56), Parent = tree.Root.Children[3].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(57), Parent = tree.Root.Children[3].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(58), Parent = tree.Root.Children[3].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(59), Parent = tree.Root.Children[3].Children[2] }
            };
            tree.Root.Children[3].Children[3].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(60), Parent = tree.Root.Children[3].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(61), Parent = tree.Root.Children[3].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(62), Parent = tree.Root.Children[3].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(63), Parent = tree.Root.Children[3].Children[3] }
            };

            tree.Root.Children[4].Children[0].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(64), Parent = tree.Root.Children[4].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(65), Parent = tree.Root.Children[4].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(66), Parent = tree.Root.Children[4].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(67), Parent = tree.Root.Children[4].Children[0] }
            };
            tree.Root.Children[4].Children[1].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(68), Parent = tree.Root.Children[4].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(69), Parent = tree.Root.Children[4].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(70), Parent = tree.Root.Children[4].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(71), Parent = tree.Root.Children[4].Children[1] }
            };
            tree.Root.Children[4].Children[2].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(72), Parent = tree.Root.Children[4].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(73), Parent = tree.Root.Children[4].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(74), Parent = tree.Root.Children[4].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(75), Parent = tree.Root.Children[4].Children[2] }
            };
            tree.Root.Children[4].Children[3].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(76), Parent = tree.Root.Children[4].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(77), Parent = tree.Root.Children[4].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(78), Parent = tree.Root.Children[4].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(79), Parent = tree.Root.Children[4].Children[3] }
            };

            tree.Root.Children[5].Children[0].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(80), Parent = tree.Root.Children[5].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(81), Parent = tree.Root.Children[5].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(82), Parent = tree.Root.Children[5].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(83), Parent = tree.Root.Children[5].Children[0] }
            };
            tree.Root.Children[5].Children[1].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(84), Parent = tree.Root.Children[5].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(85), Parent = tree.Root.Children[5].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(86), Parent = tree.Root.Children[5].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(87), Parent = tree.Root.Children[5].Children[1] }
            };
            tree.Root.Children[5].Children[2].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(88), Parent = tree.Root.Children[5].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(89), Parent = tree.Root.Children[5].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(90), Parent = tree.Root.Children[5].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(91), Parent = tree.Root.Children[5].Children[2] }
            };
            tree.Root.Children[5].Children[3].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(92), Parent = tree.Root.Children[5].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(93), Parent = tree.Root.Children[5].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(94), Parent = tree.Root.Children[5].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(95), Parent = tree.Root.Children[5].Children[3] }
            };

            tree.Root.Children[6].Children[0].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(96), Parent = tree.Root.Children[6].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(97), Parent = tree.Root.Children[6].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(98), Parent = tree.Root.Children[6].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(99), Parent = tree.Root.Children[6].Children[0] }
            };
            tree.Root.Children[6].Children[1].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(100), Parent = tree.Root.Children[6].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(101), Parent = tree.Root.Children[6].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(102), Parent = tree.Root.Children[6].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(103), Parent = tree.Root.Children[6].Children[1] }
            };
            tree.Root.Children[6].Children[2].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(104), Parent = tree.Root.Children[6].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(105), Parent = tree.Root.Children[6].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(106), Parent = tree.Root.Children[6].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(107), Parent = tree.Root.Children[6].Children[2] }
            };
            tree.Root.Children[6].Children[3].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(108), Parent = tree.Root.Children[6].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(109), Parent = tree.Root.Children[6].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(110), Parent = tree.Root.Children[6].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(111), Parent = tree.Root.Children[6].Children[3] }
            };

            tree.Root.Children[7].Children[0].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(112), Parent = tree.Root.Children[7].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(113), Parent = tree.Root.Children[7].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(114), Parent = tree.Root.Children[7].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(115), Parent = tree.Root.Children[7].Children[0] }
            };
            tree.Root.Children[7].Children[1].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(116), Parent = tree.Root.Children[7].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(117), Parent = tree.Root.Children[7].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(118), Parent = tree.Root.Children[7].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(119), Parent = tree.Root.Children[7].Children[1] }
            };
            tree.Root.Children[7].Children[2].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(120), Parent = tree.Root.Children[7].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(121), Parent = tree.Root.Children[7].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(122), Parent = tree.Root.Children[7].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(123), Parent = tree.Root.Children[7].Children[2] }
            };
            tree.Root.Children[7].Children[3].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(124), Parent = tree.Root.Children[7].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(125), Parent = tree.Root.Children[7].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(126), Parent = tree.Root.Children[7].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(127), Parent = tree.Root.Children[7].Children[3] }
            };

            tree.Root.Children[8].Children[0].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(128), Parent = tree.Root.Children[8].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(129), Parent = tree.Root.Children[8].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(130), Parent = tree.Root.Children[8].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(131), Parent = tree.Root.Children[8].Children[0] }
            };
            tree.Root.Children[8].Children[1].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(132), Parent = tree.Root.Children[8].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(133), Parent = tree.Root.Children[8].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(134), Parent = tree.Root.Children[8].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(135), Parent = tree.Root.Children[8].Children[1] }
            };
            tree.Root.Children[8].Children[2].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(136), Parent = tree.Root.Children[8].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(137), Parent = tree.Root.Children[8].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(138), Parent = tree.Root.Children[8].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(139), Parent = tree.Root.Children[8].Children[2] }
            };
            tree.Root.Children[8].Children[3].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(140), Parent = tree.Root.Children[8].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(141), Parent = tree.Root.Children[8].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(142), Parent = tree.Root.Children[8].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(143), Parent = tree.Root.Children[8].Children[3] }
            };

            tree.Root.Children[9].Children[0].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(144), Parent = tree.Root.Children[9].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(145), Parent = tree.Root.Children[9].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(146), Parent = tree.Root.Children[9].Children[0] },
                new TreeNode<string>() { Data = levlThir.ElementAt(147), Parent = tree.Root.Children[9].Children[0] }
            };
            tree.Root.Children[9].Children[1].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(148), Parent = tree.Root.Children[9].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(149), Parent = tree.Root.Children[9].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(150), Parent = tree.Root.Children[9].Children[1] },
                new TreeNode<string>() { Data = levlThir.ElementAt(151), Parent = tree.Root.Children[9].Children[1] }
            };
            tree.Root.Children[9].Children[2].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(152), Parent = tree.Root.Children[9].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(153), Parent = tree.Root.Children[9].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(154), Parent = tree.Root.Children[9].Children[2] },
                new TreeNode<string>() { Data = levlThir.ElementAt(155), Parent = tree.Root.Children[9].Children[2] }
            };
            tree.Root.Children[9].Children[3].Children = new List<TreeNode<string>> 
            {
                new TreeNode<string>() { Data = levlThir.ElementAt(156), Parent = tree.Root.Children[9].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(157), Parent = tree.Root.Children[9].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(158), Parent = tree.Root.Children[9].Children[3] },
                new TreeNode<string>() { Data = levlThir.ElementAt(159), Parent = tree.Root.Children[9].Children[3] }
            };
        }

        public void SelectAns() 
        {
            Random rnd = new Random();
            selectFirst = rnd.Next(0, 9);
            selectSecond = rnd.Next(0, 3);
            selectThird = rnd.Next(0, 3);

            ans.Add(tree.Root.Children[selectFirst].Data);
            ans.Add(tree.Root.Children[selectFirst].Children[selectSecond].Data);
            ans.Add(tree.Root.Children[selectFirst].Children[selectSecond].Children[selectThird].Data);
        }

        public void SelectOptionsFirst()
        {
            Random rand = new Random();
            roundNo++;
            opts.Add(tree.Root.Children[selectFirst].Data);
            optsCount++;
            int uniqueFir = 0;
            int uniqueSec = 0;
            int uniqueThir = 0;

            while(optsCount < 4)
            {
                int noGen = rand.Next(0, 9);

                if (noGen == selectFirst)
                {
                    
                }
                else 
                {
                    switch (optsCount)
                    {
                        case 1:
                            uniqueFir = noGen;
                            opts.Add(tree.Root.Children[noGen].Data);
                            optsCount++;
                            break;
                        case 2:
                            uniqueSec = noGen;
                            if(uniqueSec == uniqueFir)
                            {
                                break;
                            }
                            else
                            {
                                opts.Add(tree.Root.Children[noGen].Data);
                                optsCount++;
                            }
                            break;
                        case 3:
                            uniqueThir = noGen;
                            if (uniqueThir == uniqueFir || uniqueThir == uniqueSec)
                            {
                                break;
                            }
                            else
                            {
                                opts.Add(tree.Root.Children[noGen].Data);
                                optsCount++;
                            }
                            break;
                    }
                    
                }
            }
            opts.Sort();
            txbOptFir.Text = opts.ElementAt(0).ToString();
            txbOptSec.Text = opts.ElementAt(1).ToString();
            txbOptThir.Text = opts.ElementAt(2).ToString();
            txbOptFor.Text = opts.ElementAt(3).ToString();

        }

        public void SelectOptionsSecond()
        {
            roundNo++;
            optsCount = 0;
            opts.Clear();
            opts.Add(tree.Root.Children[selectFirst].Children[0].Data);
            opts.Add(tree.Root.Children[selectFirst].Children[1].Data);
            opts.Add(tree.Root.Children[selectFirst].Children[2].Data);
            opts.Add(tree.Root.Children[selectFirst].Children[3].Data);            
            opts.Sort();
            txbOptFir.Text = opts.ElementAt(0).ToString();
            txbOptSec.Text = opts.ElementAt(1).ToString();
            txbOptThir.Text = opts.ElementAt(2).ToString();
            txbOptFor.Text = opts.ElementAt(3).ToString();
        }

        public void SelectOptionsThird()
        {
            string finFir;
            string finSec;
            string finThir;
            string finFor;
            roundNo++;
            optsCount = 0;
            opts.Clear();
            opts.Add(tree.Root.Children[selectFirst].Children[selectSecond].Children[0].Data);
            opts.Add(tree.Root.Children[selectFirst].Children[selectSecond].Children[1].Data);
            opts.Add(tree.Root.Children[selectFirst].Children[selectSecond].Children[2].Data);
            opts.Add(tree.Root.Children[selectFirst].Children[selectSecond].Children[3].Data);
            opts.Sort();
            finFir = opts.ElementAt(0).ToString();
            finSec = opts.ElementAt(1).ToString();
            finThir = opts.ElementAt(2).ToString();
            finFor = opts.ElementAt(3).ToString();
            txbOptFir.Text = finFir.Remove(3, finFir.Length - 3);
            txbOptSec.Text = finSec.Remove(3, finSec.Length - 3);
            txbOptThir.Text = finThir.Remove(3, finThir.Length - 3);
            txbOptFor.Text = finFor.Remove(3, finFor.Length - 3);
        }

        public void ClearText()
        {
            txbOptFir.Clear();
            txbOptSec.Clear();
            txbOptThir.Clear();
            txbOptFor.Clear();
        }

        private void FindingCallMenu_Load(object sender, EventArgs e)
        {
            UserGet();
        }

        private void lbxPop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOptFir_Click(object sender, EventArgs e)
        {
            switch (roundNo)
            {
                case 1:
                    if (opts.ElementAt(0) == ans.ElementAt(0))
                    {
                        MessageBox.Show("This answer was correct", "Congratulations");
                        score++;
                        ClearText();
                        SelectOptionsSecond();
                    }
                    else
                    {
                        MessageBox.Show("This answer was incorrect", "Oops");
                        ClearText();
                        SelectOptionsSecond();
                    }
                    break;
                case 2:
                    if (opts.ElementAt(0) == ans.ElementAt(1))
                    {
                        MessageBox.Show("This answer was correct", "Congratulations");
                        score++;
                        ClearText();
                        SelectOptionsThird();
                    }
                    else
                    {
                        MessageBox.Show("This answer was incorrect", "Oops");
                        ClearText();
                        SelectOptionsThird();
                    }
                    break;
                case 3:
                    if (opts.ElementAt(0) == ans.ElementAt(2))
                    {
                        MessageBox.Show("This answer was correct", "Congratulations");
                        score++;
                        ApplyScore();
                        ClearText();
                        btnStart.Enabled = true;
                        btnLead.Enabled = true;
                        btnEnd.Enabled = false;
                        btnBack.Enabled = true;
                        btnOptFir.Enabled = false;
                        btnOptSec.Enabled = false;
                        btnOptThir.Enabled = false;
                        btnOptFor.Enabled = false;
                        ans.Clear();
                        opts.Clear();
                        optsCount = 0;
                        txbClue.Clear();
                    }
                    else
                    {
                        MessageBox.Show("This answer was incorrect", "Oops");
                        ApplyScore();
                        ClearText();
                        btnStart.Enabled = true;
                        btnLead.Enabled = true;
                        btnEnd.Enabled = false;
                        btnBack.Enabled = true;
                        btnOptFir.Enabled = false;
                        btnOptSec.Enabled = false;
                        btnOptThir.Enabled = false;
                        btnOptFor.Enabled = false;
                        ans.Clear();
                        opts.Clear();
                        optsCount = 0;
                        txbClue.Clear();
                    }
                    break;
            }
        }

        private void btnOptThir_Click(object sender, EventArgs e)
        {
            switch (roundNo)
            {
                case 1:
                    if (opts.ElementAt(2) == ans.ElementAt(0))
                    {
                        MessageBox.Show("This answer was correct", "Congratulations");
                        score++;
                        ClearText();
                        SelectOptionsSecond();
                    }
                    else
                    {
                        MessageBox.Show("This answer was incorrect", "Oops");
                        ClearText();
                        SelectOptionsSecond();
                    }
                    break;
                case 2:
                    if (opts.ElementAt(2) == ans.ElementAt(1))
                    {
                        MessageBox.Show("This answer was correct", "Congratulations");
                        score++;
                        ClearText();
                        SelectOptionsThird();
                    }
                    else
                    {
                        MessageBox.Show("This answer was incorrect", "Oops");
                        ClearText();
                        SelectOptionsThird();
                    }
                    break;
                case 3:
                    if (opts.ElementAt(2) == ans.ElementAt(2))
                    {
                        MessageBox.Show("This answer was correct", "Congratulations");
                        score++;
                        ApplyScore();
                        ClearText();
                        btnStart.Enabled = true;
                        btnLead.Enabled = true;
                        btnEnd.Enabled = false;
                        btnBack.Enabled = true;
                        btnOptFir.Enabled = false;
                        btnOptSec.Enabled = false;
                        btnOptThir.Enabled = false;
                        btnOptFor.Enabled = false;
                        ans.Clear();
                        opts.Clear();
                        optsCount = 0;
                        txbClue.Clear();
                    }
                    else
                    {
                        MessageBox.Show("This answer was incorrect", "Oops");
                        ApplyScore();
                        ClearText();
                        btnStart.Enabled = true;
                        btnLead.Enabled = true;
                        btnEnd.Enabled = false;
                        btnBack.Enabled = true;
                        btnOptFir.Enabled = false;
                        btnOptSec.Enabled = false;
                        btnOptThir.Enabled = false;
                        btnOptFor.Enabled = false;
                        ans.Clear();
                        opts.Clear();
                        optsCount = 0;
                        txbClue.Clear();
                    }
                    break;
            }
        }

        private void btnOptFor_Click(object sender, EventArgs e)
        {
            switch (roundNo)
            {
                case 1:
                    if (opts.ElementAt(3) == ans.ElementAt(0))
                    {
                        MessageBox.Show("This answer was correct", "Congratulations");
                        score++;
                        SelectOptionsSecond();
                    }
                    else
                    {
                        MessageBox.Show("This answer was incorrect", "Oops");
                        ClearText();
                        SelectOptionsSecond();
                    }
                    break;
                case 2:
                    if (opts.ElementAt(3) == ans.ElementAt(1))
                    {
                        MessageBox.Show("This answer was correct", "Congratulations");
                        score++;
                        SelectOptionsThird();
                    }
                    else
                    {
                        MessageBox.Show("This answer was incorrect", "Oops");
                        ClearText();
                        SelectOptionsThird();
                    }
                    break;
                case 3:
                    if (opts.ElementAt(3) == ans.ElementAt(2))
                    {
                        MessageBox.Show("This answer was correct", "Congratulations");
                        score++;
                        ApplyScore();
                        ClearText();
                        btnStart.Enabled = true;
                        btnLead.Enabled = true;
                        btnEnd.Enabled = false;
                        btnBack.Enabled = true;
                        btnOptFir.Enabled = false;
                        btnOptSec.Enabled = false;
                        btnOptThir.Enabled = false;
                        btnOptFor.Enabled = false;
                        ans.Clear();
                        opts.Clear();
                        optsCount = 0;
                        txbClue.Clear();
                    }
                    else
                    {
                        MessageBox.Show("This answer was incorrect","Oops");
                        ApplyScore();
                        ClearText();
                        btnStart.Enabled = true;
                        btnLead.Enabled = true;
                        btnEnd.Enabled = false;
                        btnBack.Enabled = true;
                        btnOptFir.Enabled = false;
                        btnOptSec.Enabled = false;
                        btnOptThir.Enabled = false;
                        btnOptFor.Enabled = false;
                        ans.Clear();
                        opts.Clear();
                        optsCount = 0;
                        txbClue.Clear();
                    }
                    break;
            }
        }
        public void ApplyScore()
        {
            int totalFinal = 0;
            switch (score)
            {
                case 0:
                    totalFinal = 0;
                    break;
                case 1:
                    totalFinal = 500;
                    break;
                case 2:
                    totalFinal = 1000;
                    break;
                case 3:
                    totalFinal = 1500;
                    break;
            }
            MessageBox.Show("Your score was " + totalFinal,"Congratulations");
            StreamReader loggedUser = new StreamReader(@"C:\Users\User\Desktop\18002919_PROG7312_POE\LibraryBookApp\LibraryBookApp\loggedIn.txt");
            string line1 = loggedUser.ReadLine();
            string line2 = loggedUser.ReadLine();

            foreach (UserStored item in userDets)
            {
                if (item.username == line1)
                {
                    item.score = item.score + totalFinal;
                }
            }
            loggedUser.Close();

            UserUpdate();
            userDets.Clear();
        }
        private void UserGet()
        {
            //fetches user details from a text file
            StreamReader userRead = new StreamReader(@"C:\Users\User\Desktop\18002919_PROG7312_POE\LibraryBookApp\LibraryBookApp\details.txt");

            while (userRead.ReadLine() != null)
            {
                string line1 = userRead.ReadLine();
                string line2 = userRead.ReadLine();
                int line3 = Convert.ToInt32(userRead.ReadLine());

                userDets.Add(new UserStored(line1, line2, line3));

            }
            userRead.Close();
        }
        private void UserUpdate()
        {
            //Updates the text file with new data
            File.WriteAllText(@"C:\Users\User\Desktop\18002919_PROG7312_POE\LibraryBookApp\LibraryBookApp\details.txt", String.Empty);
            StreamWriter update = new StreamWriter(@"C:\Users\User\Desktop\18002919_PROG7312_POE\LibraryBookApp\LibraryBookApp\details.txt");
            foreach (UserStored item in userDets)
            {

                update.WriteLine("----------------------" + "\r\n" + "" + item.username + "\r\n" + "" + item.password + "\r\n" + item.score);

            }
            update.Close();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnLead.Enabled = true;
            btnEnd.Enabled = false;
            btnBack.Enabled = true;
            btnOptFir.Enabled = false;
            btnOptSec.Enabled = false;
            btnOptThir.Enabled = false;
            btnOptFor.Enabled = false;
            ans.Clear();
            opts.Clear();
            optsCount = 0;
            txbClue.Clear();
            txbOptFir.Clear();
            txbOptSec.Clear();
            txbOptThir.Clear();
            txbOptFor.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuMain mainMenu = new MenuMain();
            mainMenu.Show();
            this.Close();
        }

        private void lbxAns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFir_Click(object sender, EventArgs e)
        {

        }

        private void lblThir_Click(object sender, EventArgs e)
        {

        }

        private void btnLead_Click(object sender, EventArgs e)
        {
            LeaderMenu leadBoar = new LeaderMenu();
            leadBoar.Show();
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
