using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindingSource = new BindingSource();
            
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBindingSource);

            LoadAllPayModeList();

            this.view.Show();
        }

        private void LoadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource= payModeList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            //Se crea un objeto de la clase PayModeModel y se asigno los datos
            // de las caja de texto de la vista 
            var payMode =new PayModeModel();
            payMode.Id = Convert.ToInt32(view.PayModeId);
            payMode.Name = view.PayModeName;
            payMode.Observation = view.PayModeObservation;

            try
            {
                if (view.IsEdit)
                {
                    repository.edit(payMode);
                    view.Message = "PayMode edited Successfuly";

                }
                else

                {
                    repository.Add(payMode);
                    view.Message = "PayMode added successfuly";

                }
            }
            catch (Exception ex) 
            {
            //Si ocurre una excepcion se configura IsSuccessfull en false
            //y a la propiedad Message de la vista se asigna el mensaje de la exception 
            view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            //se obtiene el objeto del datagridview que se encuentra Seleccionado 
            var payMode = (PayModeModel)payModeBindingSource.Current;

            //Se cambia el contenido  de las cajas de texto  por el objeto recuperado 
            //del datagridview 
            view.PayModeId = payMode.Id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeObservation= payMode.Observation;

            //Se estable el modo como edicion 
            view.IsEdit = true; 
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool EmptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (EmptyValue == false)
            {
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            else 
            {
            payModeList= repository.GetAll();
            }
            payModeBindingSource.DataSource= payModeList;
        }
    }
}
