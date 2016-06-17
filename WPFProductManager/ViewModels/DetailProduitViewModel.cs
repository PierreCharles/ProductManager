﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFProductManager.Mock;
using WPFProductManager.ViewModels.Common;

namespace WPFProductManager.ViewModels
{
    /// <summary>
    /// ViewModel représentant un Produit (avec son détail)
    /// Hérite de BaseViewModel
    /// </summary>
    public class DetailProduitViewModel : BaseViewModel
    {
        #region Variables

        private string _code;
        private string _nom;
        private string _status;
        private float _prix;
        private int _stock;
        private RelayCommand _addOperation;
        private RelayCommand _addProduct;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// <param name="p">Produit à transformer en DetailProduitViewModel</param>
        /// </summary>
        public DetailProduitViewModel(Produit p)
        {
            _code = p.Code;
            _nom = p.Nom;
            _stock = p.Stock;
            _status = p.Status;
            _prix = p.Prix;
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Code du produit
        /// </summary>
        public string Code 
        {
            get {
                return _code;
            }
            set {
                _code = value;
                OnPropertyChanged("Code");
            }
        }

        /// <summary>
        /// Nom du produit
        /// </summary>
        public string Nom
        {
            get {
                return _nom;
            }
            set {
                _nom = value;
                OnPropertyChanged("Nom");
            }
        }

        /// <summary>
        /// Stock du produit
        /// </summary>
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                OnPropertyChanged("Stock");
            }
        }

        /// <summary>
        /// Status du produit
        /// </summary>
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Prix du produit
        /// </summary>
        public float Prix
        {
            get
            {
                return _prix;
            }
            set
            {
                _prix = value;
                OnPropertyChanged("Prix");
            }
        }

        #endregion

        #region Commandes

        /// <summary>
        /// Commande pour ouvrir la fenêtre pour ajouter une opération
        /// </summary>
        public ICommand AddOperation
        {
            get
            {
                if (_addOperation == null)
                    _addOperation = new RelayCommand(() => this.ShowWindowOperation());
                return _addOperation;
            }
        }

        /// <summary>
        /// Commande pour ouvrir la fenêtre pour ajouter un produit
        /// </summary>
        public ICommand AddProduct
        {
            get
            {
                if (_addProduct == null)
                    _addProduct = new RelayCommand(() => this.ShowWindowAddProduct());
                return _addProduct;
            }
        }
 
        /// <summary>
        /// Permet l'ouverture de la fenêtre
        /// </summary>
        private void ShowWindowOperation()
        {
            Views.Operation operationWindow = new Views.Operation();
            operationWindow.DataContext = this;
            operationWindow.ShowDialog();
        }


        /// <summary>
        /// Permet l'ouverture de la fenêtre d'ajout d'un produit
        /// </summary>
        private void ShowWindowAddProduct()
        {
            Views.AjoutProduit addProductWindows = new Views.AjoutProduit();
            addProductWindows.DataContext = this;
            addProductWindows.ShowDialog();
        }


        #endregion
    }
}
