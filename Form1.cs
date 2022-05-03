using DisplayDll.library;
namespace AS2122_3G_INF_UbaldiEdoardo_BitmapDisplayVocali
{
    public partial class frmMain : Form
    {
        Button[] array = new Button[15];
        Button[] array1 = new Button[15];
        Button[] array2 = new Button[15];
        Button[] array3 = new Button[15];
        alfabeto lettere = new alfabeto();
        public frmMain()
        {
            InitializeComponent();
            
        }     
        private void btnEsegui_Click(object sender, EventArgs e)
        {
            preparaLettera();
            switch (cmbVocali.Text)
            {
                case "A":
                    stampaLettera(lettere.Lettera_A);
                    break;
                case "B":
                    stampaLettera(lettere.Lettera_B);
                    break;
                case "C":
                    stampaLettera(lettere.Lettera_C);
                    break;
                case "D":
                    stampaLettera(lettere.Lettera_D);
                    break;
                case "E":
                    stampaLettera(lettere.Lettera_E);
                    break;
                case "F":
                    stampaLettera(lettere.Lettera_F);
                    break;
                case "G":
                    stampaLettera(lettere.Lettera_G);
                    break;
                case "H":
                    stampaLettera(lettere.Lettera_H);
                    break;
                case "I":
                    stampaLettera(lettere.Lettera_I);
                    break;
                case "J":
                    stampaLettera(lettere.Lettera_J);
                    break;
                case "K":
                    stampaLettera(lettere.Lettera_K);
                    break;
                case "L":
                    stampaLettera(lettere.Lettera_L);
                    break;
                case "M":
                    stampaLettera(lettere.Lettera_M);
                    break;
                case "N":
                    stampaLettera(lettere.Lettera_N);
                    break;
                case "O":
                    stampaLettera(lettere.Lettera_O);
                    break;
                case "P":
                    stampaLettera(lettere.Lettera_P);
                    break;
                case "Q":
                    stampaLettera(lettere.Lettera_Q);
                    break;
                case "R":
                    stampaLettera(lettere.Lettera_R);
                    break;
                case "S":
                    stampaLettera(lettere.Lettera_S);
                    break;
                case "T":
                    stampaLettera(lettere.Lettera_T);
                    break;
                case "U":
                    stampaLettera(lettere.Lettera_U);
                    break;
                case "V":
                    stampaLettera(lettere.Lettera_V);
                    break;
                case "W":
                    stampaLettera(lettere.Lettera_W);
                    break;
                case "X":
                    stampaLettera(lettere.Lettera_X);
                    break;
                case "Y":
                    stampaLettera(lettere.Lettera_Y);
                    break;
                case "Z":
                    stampaLettera(lettere.Lettera_Z);
                    break;
                case "CANC":
                    stampaLettera(lettere.Lettera_CANC);
                    break;
            }
        }
        void preparaLettera()
        {
            array[0] = btn0_0;
            array[1] = btn0_1;
            array[2] = btn0_2;
            array[3] = btn1_0;
            array[4] = btn1_1;
            array[5] = btn1_2;
            array[6] = btn2_0;
            array[7] = btn2_1;
            array[8] = btn2_2;
            array[9] = btn3_0;
            array[10] = btn3_1;
            array[11] = btn3_2;
            array[12] = btn4_0;
            array[13] = btn4_1;
            array[14] = btn4_2;
            //---------------------------------------------------
            array1[0] = btn0_0_1;
            array1[1] = btn0_1_1;
            array1[2] = btn0_2_1;
            array1[3] = btn1_0_1;
            array1[4] = btn1_1_1;
            array1[5] = btn1_2_1;
            array1[6] = btn2_0_1;
            array1[7] = btn2_1_1;
            array1[8] = btn2_2_1;
            array1[9] = btn3_0_1;
            array1[10] = btn3_1_1;
            array1[11] = btn3_2_1;
            array1[12] = btn4_0_1;
            array1[13] = btn4_1_1;
            array1[14] = btn4_2_1;
            //---------------------------------------------------
            array2[0] = btn0_0_2;
            array2[1] = btn0_1_2;
            array2[2] = btn0_2_2;
            array2[3] = btn1_0_2;
            array2[4] = btn1_1_2;
            array2[5] = btn1_2_2;
            array2[6] = btn2_0_2;
            array2[7] = btn2_1_2;
            array2[8] = btn2_2_2;
            array2[9] = btn3_0_2;
            array2[10] = btn3_1_2;
            array2[11] = btn3_2_2;
            array2[12] = btn4_0_2;
            array2[13] = btn4_1_2;
            array2[14] = btn4_2_2;
            //---------------------------------------------------
            array3[0] = btn0_0_3;
            array3[1] = btn0_1_3;
            array3[2] = btn0_2_3;
            array3[3] = btn1_0_3;
            array3[4] = btn1_1_3;
            array3[5] = btn1_2_3;
            array3[6] = btn2_0_3;
            array3[7] = btn2_1_3;
            array3[8] = btn2_2_3;
            array3[9] = btn3_0_3;
            array3[10] = btn3_1_3;
            array3[11] = btn3_2_3;
            array3[12] = btn4_0_3;
            array3[13] = btn4_1_3;
            array3[14] = btn4_2_3;
        }

        void stampaLettera(int[] lettera)
        {
            for (int i = 0; i < 15; i++)
            {

                if (lettera[i] == 1)
                {
                    array[i].BackColor = Color.Red;
                }
                else
                {
                    array[i].BackColor = Color.White;
                }
            }
        }
    }
}