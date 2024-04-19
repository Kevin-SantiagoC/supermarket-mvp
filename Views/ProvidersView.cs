﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class ProvidersView : Form, IProvidersView
    {
        
        private bool isEdit;
        private bool isSuccesful;
        private string message;

        public ProvidersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageProvidersDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            }

        public string ProviderId 
        {
            get { return TxtProvidersId.Text; }
            set { TxtProvidersId.Text = value; }

        }
        public string ProviderName 
        {
            get { return TxtProvidersName.Text; }
            set { TxtProvidersName.Text = value; }

        }
        public string ProviderObservation 
        {
            get { return TxtProvidersObservation.Text; }
            set { TxtProvidersObservation.Text = value; }

        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }

        }
        public bool IsEdit 
        {
            get { return isEdit; }
            set { isEdit = value; }

        }
        public bool IsSuccesful 
        {
            get { return isSuccesful; }
            set { isSuccesful = value; }


        }
        public string Menssage 
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProvidersListBildingSource(BindingSource providersList)
        {
            DgProviders.DataSource = providersList;
        }
    }
}
