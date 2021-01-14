﻿using BankAccountManagamentLibrary.Models.ClientModel;

using Controller;

namespace BankAccountManagament.AdminsView.ClientsView {
   class MainClientsAdminView : Menu {
        
        public void ViewClients() {
        } 
        public void CreateClient() { 
           
        }

        public string GoToEditClientAdminView() {
            Container.GetDependency("CrudOperations").InvokeMethod("View", typeof(Client), null);
            return Common.Input("Client Id: ", 1);
            //return (Client)Container.GetDependency("ClientServices").InvokeMethod("Get", clientId);
            
        }

        public string RemoveClient() {
            Container.GetDependency("CrudOperations").InvokeMethod("View", typeof(Client), null);
            return Common.Input("Client Id: ", 1);
        }
    }
}