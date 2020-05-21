using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_a
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataA : ContentPage
    {
        public KataA()
        {
            InitializeComponent();
            ButtonsEventSubcriptions();
        }

        private void ButtonsEventSubcriptions()
        {
            btKata_B.Clicked += BtKata_B_Clicked;
            btKata_C.Clicked += BtKata_C_Clicked;
            btKata_D.Clicked += BtKata_D_Clicked;
            btKata_F.Clicked += BtKata_F_Clicked;
            btKata_G.Clicked += BtKata_G_Clicked;
            btKata_H.Clicked += BtKata_H_Clicked;
            btKata_I.Clicked += BtKata_I_Clicked;
            btKata_J.Clicked += BtKata_J_Clicked;
            btKata_K.Clicked += BtKata_K_Clicked;
            btKata_L.Clicked += BtKata_L_Clicked;
            btKata_M.Clicked += BtKata_M_Clicked;
            btKata_N.Clicked += BtKata_N_Clicked;
            btKata_O.Clicked += BtKata_O_Clicked;
            btKata_P.Clicked += BtKata_P_Clicked;
            btKata_Q.Clicked += BtKata_Q_Clicked;
            btKata_R.Clicked += BtKata_R_Clicked;
            btKata_S.Clicked += BtKata_S_Clicked;
            btKata_T.Clicked += BtKata_T_Clicked;
            btKata_U.Clicked += BtKata_U_Clicked;
            btKata_V.Clicked += BtKata_V_Clicked;
            btKata_W.Clicked += BtKata_W_Clicked;
            btKata_X.Clicked += BtKata_X_Clicked;
            btKata_Y.Clicked += BtKata_Y_Clicked;
            btKata_Z.Clicked += BtKata_Z_Clicked;
        }

        private void BtKata_F_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_f.KataF());
        }

        private void BtKata_Z_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_z.KataZ());
        }

        private void BtKata_Y_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_y.KataY());
        }

        private void BtKata_X_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_x.KataX());
        }

        private void BtKata_W_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_w.KataW());
        }

        private void BtKata_V_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_v.KataV());
        }

        private void BtKata_U_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_u.KataU());
        }

        private void BtKata_T_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_t.KataT());
        }

        private void BtKata_S_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_s.KataS());
        }

        private void BtKata_R_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_r.KataR());
        }

        private void BtKata_Q_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_q.KataQ());
        }

        private void BtKata_P_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_p.KataP());
        }

        private void BtKata_O_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_o.KataO());
        }

        private void BtKata_N_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_n.TabbedPage1());
        }

        private void BtKata_M_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_m.KataM());
        }

        private void BtKata_L_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_l.KataL());
        }

        private void BtKata_K_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_k.KataK());
        }

        private void BtKata_J_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_j.KataJ());
        }

        private void BtKata_I_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_i.KataI());
        }

        private void BtKata_H_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_h.KataH());
        }

        private void BtKata_G_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_g.KataG());
        }

        private void BtKata_D_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_d.KataD());
        }

        private void BtKata_C_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_c.MasterDetailPage1());
        }

        private void BtKata_B_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_b.KataB());
        }

    }
}