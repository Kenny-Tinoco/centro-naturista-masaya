using System;
using System.ComponentModel;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region Metadatos de relaciones en EDM

[assembly: EdmRelationshipAttribute("MasayaNaturistCenterModel", "FK__Consult__idEmplo__4222D4EF", "Employee", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(MasayaNaturistCenter.Model.Models.Employee), "Consult", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MasayaNaturistCenter.Model.Models.Consult), true)]
[assembly: EdmRelationshipAttribute("MasayaNaturistCenterModel", "FK__Consult__idPatie__4316F928", "Patient", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(MasayaNaturistCenter.Model.Models.Patient), "Consult", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MasayaNaturistCenter.Model.Models.Consult), true)]
[assembly: EdmRelationshipAttribute("MasayaNaturistCenterModel", "FK__Prescript__idCon__45F365D3", "Consult", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(MasayaNaturistCenter.Model.Models.Consult), "PrescriptionProduct", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MasayaNaturistCenter.Model.Models.PrescriptionProduct), true)]
[assembly: EdmRelationshipAttribute("MasayaNaturistCenterModel", "FK__Sell__idEmployee__2E1BDC42", "Employee", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(MasayaNaturistCenter.Model.Models.Employee), "Sell", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MasayaNaturistCenter.Model.Models.Sell), true)]
[assembly: EdmRelationshipAttribute("MasayaNaturistCenterModel", "FK__Prescript__idPro__46E78A0C", "Product", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(MasayaNaturistCenter.Model.Models.Product), "PrescriptionProduct", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MasayaNaturistCenter.Model.Models.PrescriptionProduct), true)]
[assembly: EdmRelationshipAttribute("MasayaNaturistCenterModel", "FK__Stock__idPresent__37A5467C", "Presentation", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(MasayaNaturistCenter.Model.Models.Presentation), "Stock", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MasayaNaturistCenter.Model.Models.Stock), true)]
[assembly: EdmRelationshipAttribute("MasayaNaturistCenterModel", "FK__Stock__idProduct__36B12243", "Product", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(MasayaNaturistCenter.Model.Models.Product), "Stock", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MasayaNaturistCenter.Model.Models.Stock), true)]
[assembly: EdmRelationshipAttribute("MasayaNaturistCenterModel", "FK__ProviderP__idPro__33D4B598", "Provider", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(MasayaNaturistCenter.Model.Models.Provider), "ProviderPhone", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MasayaNaturistCenter.Model.Models.ProviderPhone), true)]
[assembly: EdmRelationshipAttribute("MasayaNaturistCenterModel", "FK__Supply__idProvid__30F848ED", "Provider", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(MasayaNaturistCenter.Model.Models.Provider), "Supply", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MasayaNaturistCenter.Model.Models.Supply), true)]
[assembly: EdmRelationshipAttribute("MasayaNaturistCenterModel", "FK__SaleDetai__idSel__3A81B327", "Sell", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(MasayaNaturistCenter.Model.Models.Sell), "SaleDetail", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MasayaNaturistCenter.Model.Models.SaleDetail), true)]
[assembly: EdmRelationshipAttribute("MasayaNaturistCenterModel", "FK__SaleDetai__idSto__3B75D760", "Stock", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(MasayaNaturistCenter.Model.Models.Stock), "SaleDetail", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MasayaNaturistCenter.Model.Models.SaleDetail), true)]
[assembly: EdmRelationshipAttribute("MasayaNaturistCenterModel", "FK__SupplyDet__idSto__3F466844", "Stock", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(MasayaNaturistCenter.Model.Models.Stock), "SupplyDetail", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MasayaNaturistCenter.Model.Models.SupplyDetail), true)]
[assembly: EdmRelationshipAttribute("MasayaNaturistCenterModel", "FK__SupplyDet__idSup__3E52440B", "Supply", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(MasayaNaturistCenter.Model.Models.Supply), "SupplyDetail", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MasayaNaturistCenter.Model.Models.SupplyDetail), true)]

#endregion

namespace MasayaNaturistCenter.Model.Models
{
    #region Contextos

    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class MasayaNaturistCenterEntity : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto MasayaNaturistCenterEntity usando la cadena de conexión encontrada en la sección 'MasayaNaturistCenterEntity' del archivo de configuración de la aplicación.
        /// </summary>
        public MasayaNaturistCenterEntity() : base("name=MasayaNaturistCenterEntity", "MasayaNaturistCenterEntity")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto MasayaNaturistCenterEntity.
        /// </summary>
        public MasayaNaturistCenterEntity(string connectionString) : base(connectionString, "MasayaNaturistCenterEntity")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto MasayaNaturistCenterEntity.
        /// </summary>
        public MasayaNaturistCenterEntity(EntityConnection connection) : base(connection, "MasayaNaturistCenterEntity")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Consult> Consult
        {
            get
            {
                if ((_Consult == null))
                {
                    _Consult = base.CreateObjectSet<Consult>("Consult");
                }
                return _Consult;
            }
        }
        private ObjectSet<Consult> _Consult;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Employee> Employee
        {
            get
            {
                if ((_Employee == null))
                {
                    _Employee = base.CreateObjectSet<Employee>("Employee");
                }
                return _Employee;
            }
        }
        private ObjectSet<Employee> _Employee;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Patient> Patient
        {
            get
            {
                if ((_Patient == null))
                {
                    _Patient = base.CreateObjectSet<Patient>("Patient");
                }
                return _Patient;
            }
        }
        private ObjectSet<Patient> _Patient;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<PrescriptionProduct> PrescriptionProduct
        {
            get
            {
                if ((_PrescriptionProduct == null))
                {
                    _PrescriptionProduct = base.CreateObjectSet<PrescriptionProduct>("PrescriptionProduct");
                }
                return _PrescriptionProduct;
            }
        }
        private ObjectSet<PrescriptionProduct> _PrescriptionProduct;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Presentation> Presentation
        {
            get
            {
                if ((_Presentation == null))
                {
                    _Presentation = base.CreateObjectSet<Presentation>("Presentation");
                }
                return _Presentation;
            }
        }
        private ObjectSet<Presentation> _Presentation;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Product> Product
        {
            get
            {
                if ((_Product == null))
                {
                    _Product = base.CreateObjectSet<Product>("Product");
                }
                return _Product;
            }
        }
        private ObjectSet<Product> _Product;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Provider> Provider
        {
            get
            {
                if ((_Provider == null))
                {
                    _Provider = base.CreateObjectSet<Provider>("Provider");
                }
                return _Provider;
            }
        }
        private ObjectSet<Provider> _Provider;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<ProviderPhone> ProviderPhone
        {
            get
            {
                if ((_ProviderPhone == null))
                {
                    _ProviderPhone = base.CreateObjectSet<ProviderPhone>("ProviderPhone");
                }
                return _ProviderPhone;
            }
        }
        private ObjectSet<ProviderPhone> _ProviderPhone;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<SaleDetail> SaleDetail
        {
            get
            {
                if ((_SaleDetail == null))
                {
                    _SaleDetail = base.CreateObjectSet<SaleDetail>("SaleDetail");
                }
                return _SaleDetail;
            }
        }
        private ObjectSet<SaleDetail> _SaleDetail;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Sell> Sell
        {
            get
            {
                if ((_Sell == null))
                {
                    _Sell = base.CreateObjectSet<Sell>("Sell");
                }
                return _Sell;
            }
        }
        private ObjectSet<Sell> _Sell;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Stock> Stock
        {
            get
            {
                if ((_Stock == null))
                {
                    _Stock = base.CreateObjectSet<Stock>("Stock");
                }
                return _Stock;
            }
        }
        private ObjectSet<Stock> _Stock;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Supply> Supply
        {
            get
            {
                if ((_Supply == null))
                {
                    _Supply = base.CreateObjectSet<Supply>("Supply");
                }
                return _Supply;
            }
        }
        private ObjectSet<Supply> _Supply;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<SupplyDetail> SupplyDetail
        {
            get
            {
                if ((_SupplyDetail == null))
                {
                    _SupplyDetail = base.CreateObjectSet<SupplyDetail>("SupplyDetail");
                }
                return _SupplyDetail;
            }
        }
        private ObjectSet<SupplyDetail> _SupplyDetail;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Consult. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToConsult(Consult consult)
        {
            base.AddObject("Consult", consult);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Employee. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToEmployee(Employee employee)
        {
            base.AddObject("Employee", employee);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Patient. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToPatient(Patient patient)
        {
            base.AddObject("Patient", patient);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet PrescriptionProduct. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToPrescriptionProduct(PrescriptionProduct prescriptionProduct)
        {
            base.AddObject("PrescriptionProduct", prescriptionProduct);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Presentation. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToPresentation(Presentation presentation)
        {
            base.AddObject("Presentation", presentation);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Product. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToProduct(Product product)
        {
            base.AddObject("Product", product);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Provider. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToProvider(Provider provider)
        {
            base.AddObject("Provider", provider);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet ProviderPhone. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToProviderPhone(ProviderPhone providerPhone)
        {
            base.AddObject("ProviderPhone", providerPhone);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet SaleDetail. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToSaleDetail(SaleDetail saleDetail)
        {
            base.AddObject("SaleDetail", saleDetail);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Sell. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToSell(Sell sell)
        {
            base.AddObject("Sell", sell);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Stock. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToStock(Stock stock)
        {
            base.AddObject("Stock", stock);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Supply. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToSupply(Supply supply)
        {
            base.AddObject("Supply", supply);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet SupplyDetail. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToSupplyDetail(SupplyDetail supplyDetail)
        {
            base.AddObject("SupplyDetail", supplyDetail);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MasayaNaturistCenterModel", Name="Consult")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Consult : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Consult.
        /// </summary>
        /// <param name="idConsult">Valor inicial de la propiedad idConsult.</param>
        /// <param name="idEmployee">Valor inicial de la propiedad idEmployee.</param>
        /// <param name="idPatient">Valor inicial de la propiedad idPatient.</param>
        /// <param name="date">Valor inicial de la propiedad date.</param>
        public static Consult CreateConsult(global::System.Int32 idConsult, global::System.Int32 idEmployee, global::System.Int32 idPatient, global::System.String date)
        {
            Consult consult = new Consult();
            consult.idConsult = idConsult;
            consult.idEmployee = idEmployee;
            consult.idPatient = idPatient;
            consult.date = date;
            return consult;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idConsult
        {
            get
            {
                return _idConsult;
            }
            set
            {
                if (_idConsult != value)
                {
                    OnidConsultChanging(value);
                    ReportPropertyChanging("idConsult");
                    _idConsult = StructuralObject.SetValidValue(value, "idConsult");
                    ReportPropertyChanged("idConsult");
                    OnidConsultChanged();
                }
            }
        }
        private global::System.Int32 _idConsult;
        partial void OnidConsultChanging(global::System.Int32 value);
        partial void OnidConsultChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idEmployee
        {
            get
            {
                return _idEmployee;
            }
            set
            {
                OnidEmployeeChanging(value);
                ReportPropertyChanging("idEmployee");
                _idEmployee = StructuralObject.SetValidValue(value, "idEmployee");
                ReportPropertyChanged("idEmployee");
                OnidEmployeeChanged();
            }
        }
        private global::System.Int32 _idEmployee;
        partial void OnidEmployeeChanging(global::System.Int32 value);
        partial void OnidEmployeeChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idPatient
        {
            get
            {
                return _idPatient;
            }
            set
            {
                OnidPatientChanging(value);
                ReportPropertyChanging("idPatient");
                _idPatient = StructuralObject.SetValidValue(value, "idPatient");
                ReportPropertyChanged("idPatient");
                OnidPatientChanged();
            }
        }
        private global::System.Int32 _idPatient;
        partial void OnidPatientChanging(global::System.Int32 value);
        partial void OnidPatientChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String symptom
        {
            get
            {
                return _symptom;
            }
            set
            {
                OnsymptomChanging(value);
                ReportPropertyChanging("symptom");
                _symptom = StructuralObject.SetValidValue(value, true, "symptom");
                ReportPropertyChanged("symptom");
                OnsymptomChanged();
            }
        }
        private global::System.String _symptom;
        partial void OnsymptomChanging(global::System.String value);
        partial void OnsymptomChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String date
        {
            get
            {
                return _date;
            }
            set
            {
                OndateChanging(value);
                ReportPropertyChanging("date");
                _date = StructuralObject.SetValidValue(value, false, "date");
                ReportPropertyChanged("date");
                OndateChanged();
            }
        }
        private global::System.String _date;
        partial void OndateChanging(global::System.String value);
        partial void OndateChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Consult__idEmplo__4222D4EF", "Employee")]
        public Employee Employee
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("MasayaNaturistCenterModel.FK__Consult__idEmplo__4222D4EF", "Employee").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("MasayaNaturistCenterModel.FK__Consult__idEmplo__4222D4EF", "Employee").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Employee> EmployeeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("MasayaNaturistCenterModel.FK__Consult__idEmplo__4222D4EF", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Employee>("MasayaNaturistCenterModel.FK__Consult__idEmplo__4222D4EF", "Employee", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Consult__idPatie__4316F928", "Patient")]
        public Patient Patient
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Patient>("MasayaNaturistCenterModel.FK__Consult__idPatie__4316F928", "Patient").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Patient>("MasayaNaturistCenterModel.FK__Consult__idPatie__4316F928", "Patient").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Patient> PatientReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Patient>("MasayaNaturistCenterModel.FK__Consult__idPatie__4316F928", "Patient");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Patient>("MasayaNaturistCenterModel.FK__Consult__idPatie__4316F928", "Patient", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Prescript__idCon__45F365D3", "PrescriptionProduct")]
        public EntityCollection<PrescriptionProduct> PrescriptionProduct
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<PrescriptionProduct>("MasayaNaturistCenterModel.FK__Prescript__idCon__45F365D3", "PrescriptionProduct");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<PrescriptionProduct>("MasayaNaturistCenterModel.FK__Prescript__idCon__45F365D3", "PrescriptionProduct", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MasayaNaturistCenterModel", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Employee.
        /// </summary>
        /// <param name="idEmployee">Valor inicial de la propiedad idEmployee.</param>
        /// <param name="name">Valor inicial de la propiedad name.</param>
        public static Employee CreateEmployee(global::System.Int32 idEmployee, global::System.String name)
        {
            Employee employee = new Employee();
            employee.idEmployee = idEmployee;
            employee.name = name;
            return employee;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idEmployee
        {
            get
            {
                return _idEmployee;
            }
            set
            {
                if (_idEmployee != value)
                {
                    OnidEmployeeChanging(value);
                    ReportPropertyChanging("idEmployee");
                    _idEmployee = StructuralObject.SetValidValue(value, "idEmployee");
                    ReportPropertyChanged("idEmployee");
                    OnidEmployeeChanged();
                }
            }
        }
        private global::System.Int32 _idEmployee;
        partial void OnidEmployeeChanging(global::System.Int32 value);
        partial void OnidEmployeeChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false, "name");
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String lastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                OnlastNameChanging(value);
                ReportPropertyChanging("lastName");
                _lastName = StructuralObject.SetValidValue(value, true, "lastName");
                ReportPropertyChanged("lastName");
                OnlastNameChanged();
            }
        }
        private global::System.String _lastName;
        partial void OnlastNameChanging(global::System.String value);
        partial void OnlastNameChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String address
        {
            get
            {
                return _address;
            }
            set
            {
                OnaddressChanging(value);
                ReportPropertyChanging("address");
                _address = StructuralObject.SetValidValue(value, true, "address");
                ReportPropertyChanged("address");
                OnaddressChanged();
            }
        }
        private global::System.String _address;
        partial void OnaddressChanging(global::System.String value);
        partial void OnaddressChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String position
        {
            get
            {
                return _position;
            }
            set
            {
                OnpositionChanging(value);
                ReportPropertyChanging("position");
                _position = StructuralObject.SetValidValue(value, true, "position");
                ReportPropertyChanged("position");
                OnpositionChanged();
            }
        }
        private global::System.String _position;
        partial void OnpositionChanging(global::System.String value);
        partial void OnpositionChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Consult__idEmplo__4222D4EF", "Consult")]
        public EntityCollection<Consult> Consult
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Consult>("MasayaNaturistCenterModel.FK__Consult__idEmplo__4222D4EF", "Consult");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Consult>("MasayaNaturistCenterModel.FK__Consult__idEmplo__4222D4EF", "Consult", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Sell__idEmployee__2E1BDC42", "Sell")]
        public EntityCollection<Sell> Sell
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Sell>("MasayaNaturistCenterModel.FK__Sell__idEmployee__2E1BDC42", "Sell");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Sell>("MasayaNaturistCenterModel.FK__Sell__idEmployee__2E1BDC42", "Sell", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MasayaNaturistCenterModel", Name="Patient")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Patient : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Patient.
        /// </summary>
        /// <param name="idPatient">Valor inicial de la propiedad idPatient.</param>
        /// <param name="name">Valor inicial de la propiedad name.</param>
        public static Patient CreatePatient(global::System.Int32 idPatient, global::System.String name)
        {
            Patient patient = new Patient();
            patient.idPatient = idPatient;
            patient.name = name;
            return patient;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idPatient
        {
            get
            {
                return _idPatient;
            }
            set
            {
                if (_idPatient != value)
                {
                    OnidPatientChanging(value);
                    ReportPropertyChanging("idPatient");
                    _idPatient = StructuralObject.SetValidValue(value, "idPatient");
                    ReportPropertyChanged("idPatient");
                    OnidPatientChanged();
                }
            }
        }
        private global::System.Int32 _idPatient;
        partial void OnidPatientChanging(global::System.Int32 value);
        partial void OnidPatientChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false, "name");
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String lastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                OnlastNameChanging(value);
                ReportPropertyChanging("lastName");
                _lastName = StructuralObject.SetValidValue(value, true, "lastName");
                ReportPropertyChanged("lastName");
                OnlastNameChanged();
            }
        }
        private global::System.String _lastName;
        partial void OnlastNameChanging(global::System.String value);
        partial void OnlastNameChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String address
        {
            get
            {
                return _address;
            }
            set
            {
                OnaddressChanging(value);
                ReportPropertyChanging("address");
                _address = StructuralObject.SetValidValue(value, true, "address");
                ReportPropertyChanged("address");
                OnaddressChanged();
            }
        }
        private global::System.String _address;
        partial void OnaddressChanging(global::System.String value);
        partial void OnaddressChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> age
        {
            get
            {
                return _age;
            }
            set
            {
                OnageChanging(value);
                ReportPropertyChanging("age");
                _age = StructuralObject.SetValidValue(value, "age");
                ReportPropertyChanged("age");
                OnageChanged();
            }
        }
        private Nullable<global::System.Int32> _age;
        partial void OnageChanging(Nullable<global::System.Int32> value);
        partial void OnageChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Consult__idPatie__4316F928", "Consult")]
        public EntityCollection<Consult> Consult
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Consult>("MasayaNaturistCenterModel.FK__Consult__idPatie__4316F928", "Consult");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Consult>("MasayaNaturistCenterModel.FK__Consult__idPatie__4316F928", "Consult", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MasayaNaturistCenterModel", Name="PrescriptionProduct")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PrescriptionProduct : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto PrescriptionProduct.
        /// </summary>
        /// <param name="idPrescriptionProduct">Valor inicial de la propiedad idPrescriptionProduct.</param>
        /// <param name="idConsult">Valor inicial de la propiedad idConsult.</param>
        /// <param name="idProduct">Valor inicial de la propiedad idProduct.</param>
        public static PrescriptionProduct CreatePrescriptionProduct(global::System.Int32 idPrescriptionProduct, global::System.Int32 idConsult, global::System.Int32 idProduct)
        {
            PrescriptionProduct prescriptionProduct = new PrescriptionProduct();
            prescriptionProduct.idPrescriptionProduct = idPrescriptionProduct;
            prescriptionProduct.idConsult = idConsult;
            prescriptionProduct.idProduct = idProduct;
            return prescriptionProduct;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idPrescriptionProduct
        {
            get
            {
                return _idPrescriptionProduct;
            }
            set
            {
                if (_idPrescriptionProduct != value)
                {
                    OnidPrescriptionProductChanging(value);
                    ReportPropertyChanging("idPrescriptionProduct");
                    _idPrescriptionProduct = StructuralObject.SetValidValue(value, "idPrescriptionProduct");
                    ReportPropertyChanged("idPrescriptionProduct");
                    OnidPrescriptionProductChanged();
                }
            }
        }
        private global::System.Int32 _idPrescriptionProduct;
        partial void OnidPrescriptionProductChanging(global::System.Int32 value);
        partial void OnidPrescriptionProductChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idConsult
        {
            get
            {
                return _idConsult;
            }
            set
            {
                OnidConsultChanging(value);
                ReportPropertyChanging("idConsult");
                _idConsult = StructuralObject.SetValidValue(value, "idConsult");
                ReportPropertyChanged("idConsult");
                OnidConsultChanged();
            }
        }
        private global::System.Int32 _idConsult;
        partial void OnidConsultChanging(global::System.Int32 value);
        partial void OnidConsultChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idProduct
        {
            get
            {
                return _idProduct;
            }
            set
            {
                OnidProductChanging(value);
                ReportPropertyChanging("idProduct");
                _idProduct = StructuralObject.SetValidValue(value, "idProduct");
                ReportPropertyChanged("idProduct");
                OnidProductChanged();
            }
        }
        private global::System.Int32 _idProduct;
        partial void OnidProductChanging(global::System.Int32 value);
        partial void OnidProductChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Prescript__idCon__45F365D3", "Consult")]
        public Consult Consult
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Consult>("MasayaNaturistCenterModel.FK__Prescript__idCon__45F365D3", "Consult").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Consult>("MasayaNaturistCenterModel.FK__Prescript__idCon__45F365D3", "Consult").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Consult> ConsultReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Consult>("MasayaNaturistCenterModel.FK__Prescript__idCon__45F365D3", "Consult");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Consult>("MasayaNaturistCenterModel.FK__Prescript__idCon__45F365D3", "Consult", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Prescript__idPro__46E78A0C", "Product")]
        public Product Product
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("MasayaNaturistCenterModel.FK__Prescript__idPro__46E78A0C", "Product").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("MasayaNaturistCenterModel.FK__Prescript__idPro__46E78A0C", "Product").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Product> ProductReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("MasayaNaturistCenterModel.FK__Prescript__idPro__46E78A0C", "Product");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Product>("MasayaNaturistCenterModel.FK__Prescript__idPro__46E78A0C", "Product", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MasayaNaturistCenterModel", Name="Presentation")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Presentation : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Presentation.
        /// </summary>
        /// <param name="idPresentation">Valor inicial de la propiedad idPresentation.</param>
        /// <param name="name">Valor inicial de la propiedad name.</param>
        public static Presentation CreatePresentation(global::System.Int32 idPresentation, global::System.String name)
        {
            Presentation presentation = new Presentation();
            presentation.idPresentation = idPresentation;
            presentation.name = name;
            return presentation;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idPresentation
        {
            get
            {
                return _idPresentation;
            }
            set
            {
                if (_idPresentation != value)
                {
                    OnidPresentationChanging(value);
                    ReportPropertyChanging("idPresentation");
                    _idPresentation = StructuralObject.SetValidValue(value, "idPresentation");
                    ReportPropertyChanged("idPresentation");
                    OnidPresentationChanged();
                }
            }
        }
        private global::System.Int32 _idPresentation;
        partial void OnidPresentationChanging(global::System.Int32 value);
        partial void OnidPresentationChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false, "name");
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Stock__idPresent__37A5467C", "Stock")]
        public EntityCollection<Stock> Stock
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Stock>("MasayaNaturistCenterModel.FK__Stock__idPresent__37A5467C", "Stock");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Stock>("MasayaNaturistCenterModel.FK__Stock__idPresent__37A5467C", "Stock", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MasayaNaturistCenterModel", Name="Product")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Product : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Product.
        /// </summary>
        /// <param name="idProduct">Valor inicial de la propiedad idProduct.</param>
        /// <param name="name">Valor inicial de la propiedad name.</param>
        /// <param name="quantity">Valor inicial de la propiedad quantity.</param>
        public static Product CreateProduct(global::System.Int32 idProduct, global::System.String name, global::System.Int32 quantity)
        {
            Product product = new Product();
            product.idProduct = idProduct;
            product.name = name;
            product.quantity = quantity;
            return product;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idProduct
        {
            get
            {
                return _idProduct;
            }
            set
            {
                if (_idProduct != value)
                {
                    OnidProductChanging(value);
                    ReportPropertyChanging("idProduct");
                    _idProduct = StructuralObject.SetValidValue(value, "idProduct");
                    ReportPropertyChanged("idProduct");
                    OnidProductChanged();
                }
            }
        }
        private global::System.Int32 _idProduct;
        partial void OnidProductChanging(global::System.Int32 value);
        partial void OnidProductChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false, "name");
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String description
        {
            get
            {
                return _description;
            }
            set
            {
                OndescriptionChanging(value);
                ReportPropertyChanging("description");
                _description = StructuralObject.SetValidValue(value, true, "description");
                ReportPropertyChanged("description");
                OndescriptionChanged();
            }
        }
        private global::System.String _description;
        partial void OndescriptionChanging(global::System.String value);
        partial void OndescriptionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                OnquantityChanging(value);
                ReportPropertyChanging("quantity");
                _quantity = StructuralObject.SetValidValue(value, "quantity");
                ReportPropertyChanged("quantity");
                OnquantityChanged();
            }
        }
        private global::System.Int32 _quantity;
        partial void OnquantityChanging(global::System.Int32 value);
        partial void OnquantityChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Prescript__idPro__46E78A0C", "PrescriptionProduct")]
        public EntityCollection<PrescriptionProduct> PrescriptionProduct
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<PrescriptionProduct>("MasayaNaturistCenterModel.FK__Prescript__idPro__46E78A0C", "PrescriptionProduct");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<PrescriptionProduct>("MasayaNaturistCenterModel.FK__Prescript__idPro__46E78A0C", "PrescriptionProduct", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Stock__idProduct__36B12243", "Stock")]
        public EntityCollection<Stock> Stock
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Stock>("MasayaNaturistCenterModel.FK__Stock__idProduct__36B12243", "Stock");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Stock>("MasayaNaturistCenterModel.FK__Stock__idProduct__36B12243", "Stock", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MasayaNaturistCenterModel", Name="Provider")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Provider : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Provider.
        /// </summary>
        /// <param name="idProvider">Valor inicial de la propiedad idProvider.</param>
        /// <param name="name">Valor inicial de la propiedad name.</param>
        public static Provider CreateProvider(global::System.Int32 idProvider, global::System.String name)
        {
            Provider provider = new Provider();
            provider.idProvider = idProvider;
            provider.name = name;
            return provider;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idProvider
        {
            get
            {
                return _idProvider;
            }
            set
            {
                if (_idProvider != value)
                {
                    OnidProviderChanging(value);
                    ReportPropertyChanging("idProvider");
                    _idProvider = StructuralObject.SetValidValue(value, "idProvider");
                    ReportPropertyChanged("idProvider");
                    OnidProviderChanged();
                }
            }
        }
        private global::System.Int32 _idProvider;
        partial void OnidProviderChanging(global::System.Int32 value);
        partial void OnidProviderChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false, "name");
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String address
        {
            get
            {
                return _address;
            }
            set
            {
                OnaddressChanging(value);
                ReportPropertyChanging("address");
                _address = StructuralObject.SetValidValue(value, true, "address");
                ReportPropertyChanged("address");
                OnaddressChanged();
            }
        }
        private global::System.String _address;
        partial void OnaddressChanging(global::System.String value);
        partial void OnaddressChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ruc
        {
            get
            {
                return _ruc;
            }
            set
            {
                OnrucChanging(value);
                ReportPropertyChanging("ruc");
                _ruc = StructuralObject.SetValidValue(value, true, "ruc");
                ReportPropertyChanged("ruc");
                OnrucChanged();
            }
        }
        private global::System.String _ruc;
        partial void OnrucChanging(global::System.String value);
        partial void OnrucChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__ProviderP__idPro__33D4B598", "ProviderPhone")]
        public EntityCollection<ProviderPhone> ProviderPhone
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ProviderPhone>("MasayaNaturistCenterModel.FK__ProviderP__idPro__33D4B598", "ProviderPhone");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ProviderPhone>("MasayaNaturistCenterModel.FK__ProviderP__idPro__33D4B598", "ProviderPhone", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Supply__idProvid__30F848ED", "Supply")]
        public EntityCollection<Supply> Supply
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Supply>("MasayaNaturistCenterModel.FK__Supply__idProvid__30F848ED", "Supply");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Supply>("MasayaNaturistCenterModel.FK__Supply__idProvid__30F848ED", "Supply", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MasayaNaturistCenterModel", Name="ProviderPhone")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ProviderPhone : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto ProviderPhone.
        /// </summary>
        /// <param name="idProviderPhone">Valor inicial de la propiedad idProviderPhone.</param>
        /// <param name="idProvider">Valor inicial de la propiedad idProvider.</param>
        public static ProviderPhone CreateProviderPhone(global::System.Int32 idProviderPhone, global::System.Int32 idProvider)
        {
            ProviderPhone providerPhone = new ProviderPhone();
            providerPhone.idProviderPhone = idProviderPhone;
            providerPhone.idProvider = idProvider;
            return providerPhone;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idProviderPhone
        {
            get
            {
                return _idProviderPhone;
            }
            set
            {
                if (_idProviderPhone != value)
                {
                    OnidProviderPhoneChanging(value);
                    ReportPropertyChanging("idProviderPhone");
                    _idProviderPhone = StructuralObject.SetValidValue(value, "idProviderPhone");
                    ReportPropertyChanged("idProviderPhone");
                    OnidProviderPhoneChanged();
                }
            }
        }
        private global::System.Int32 _idProviderPhone;
        partial void OnidProviderPhoneChanging(global::System.Int32 value);
        partial void OnidProviderPhoneChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idProvider
        {
            get
            {
                return _idProvider;
            }
            set
            {
                OnidProviderChanging(value);
                ReportPropertyChanging("idProvider");
                _idProvider = StructuralObject.SetValidValue(value, "idProvider");
                ReportPropertyChanged("idProvider");
                OnidProviderChanged();
            }
        }
        private global::System.Int32 _idProvider;
        partial void OnidProviderChanging(global::System.Int32 value);
        partial void OnidProviderChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__ProviderP__idPro__33D4B598", "Provider")]
        public Provider Provider
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Provider>("MasayaNaturistCenterModel.FK__ProviderP__idPro__33D4B598", "Provider").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Provider>("MasayaNaturistCenterModel.FK__ProviderP__idPro__33D4B598", "Provider").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Provider> ProviderReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Provider>("MasayaNaturistCenterModel.FK__ProviderP__idPro__33D4B598", "Provider");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Provider>("MasayaNaturistCenterModel.FK__ProviderP__idPro__33D4B598", "Provider", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MasayaNaturistCenterModel", Name="SaleDetail")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class SaleDetail : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto SaleDetail.
        /// </summary>
        /// <param name="idSaleDetail">Valor inicial de la propiedad idSaleDetail.</param>
        /// <param name="idSell">Valor inicial de la propiedad idSell.</param>
        /// <param name="idStock">Valor inicial de la propiedad idStock.</param>
        /// <param name="quantity">Valor inicial de la propiedad quantity.</param>
        /// <param name="price">Valor inicial de la propiedad price.</param>
        /// <param name="total">Valor inicial de la propiedad total.</param>
        public static SaleDetail CreateSaleDetail(global::System.Int32 idSaleDetail, global::System.Int32 idSell, global::System.Int32 idStock, global::System.Int32 quantity, global::System.Double price, global::System.Double total)
        {
            SaleDetail saleDetail = new SaleDetail();
            saleDetail.idSaleDetail = idSaleDetail;
            saleDetail.idSell = idSell;
            saleDetail.idStock = idStock;
            saleDetail.quantity = quantity;
            saleDetail.price = price;
            saleDetail.total = total;
            return saleDetail;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idSaleDetail
        {
            get
            {
                return _idSaleDetail;
            }
            set
            {
                if (_idSaleDetail != value)
                {
                    OnidSaleDetailChanging(value);
                    ReportPropertyChanging("idSaleDetail");
                    _idSaleDetail = StructuralObject.SetValidValue(value, "idSaleDetail");
                    ReportPropertyChanged("idSaleDetail");
                    OnidSaleDetailChanged();
                }
            }
        }
        private global::System.Int32 _idSaleDetail;
        partial void OnidSaleDetailChanging(global::System.Int32 value);
        partial void OnidSaleDetailChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idSell
        {
            get
            {
                return _idSell;
            }
            set
            {
                OnidSellChanging(value);
                ReportPropertyChanging("idSell");
                _idSell = StructuralObject.SetValidValue(value, "idSell");
                ReportPropertyChanged("idSell");
                OnidSellChanged();
            }
        }
        private global::System.Int32 _idSell;
        partial void OnidSellChanging(global::System.Int32 value);
        partial void OnidSellChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idStock
        {
            get
            {
                return _idStock;
            }
            set
            {
                OnidStockChanging(value);
                ReportPropertyChanging("idStock");
                _idStock = StructuralObject.SetValidValue(value, "idStock");
                ReportPropertyChanged("idStock");
                OnidStockChanged();
            }
        }
        private global::System.Int32 _idStock;
        partial void OnidStockChanging(global::System.Int32 value);
        partial void OnidStockChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                OnquantityChanging(value);
                ReportPropertyChanging("quantity");
                _quantity = StructuralObject.SetValidValue(value, "quantity");
                ReportPropertyChanged("quantity");
                OnquantityChanged();
            }
        }
        private global::System.Int32 _quantity;
        partial void OnquantityChanging(global::System.Int32 value);
        partial void OnquantityChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double price
        {
            get
            {
                return _price;
            }
            set
            {
                OnpriceChanging(value);
                ReportPropertyChanging("price");
                _price = StructuralObject.SetValidValue(value, "price");
                ReportPropertyChanged("price");
                OnpriceChanged();
            }
        }
        private global::System.Double _price;
        partial void OnpriceChanging(global::System.Double value);
        partial void OnpriceChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double total
        {
            get
            {
                return _total;
            }
            set
            {
                OntotalChanging(value);
                ReportPropertyChanging("total");
                _total = StructuralObject.SetValidValue(value, "total");
                ReportPropertyChanged("total");
                OntotalChanged();
            }
        }
        private global::System.Double _total;
        partial void OntotalChanging(global::System.Double value);
        partial void OntotalChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__SaleDetai__idSel__3A81B327", "Sell")]
        public Sell Sell
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Sell>("MasayaNaturistCenterModel.FK__SaleDetai__idSel__3A81B327", "Sell").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Sell>("MasayaNaturistCenterModel.FK__SaleDetai__idSel__3A81B327", "Sell").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Sell> SellReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Sell>("MasayaNaturistCenterModel.FK__SaleDetai__idSel__3A81B327", "Sell");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Sell>("MasayaNaturistCenterModel.FK__SaleDetai__idSel__3A81B327", "Sell", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__SaleDetai__idSto__3B75D760", "Stock")]
        public Stock Stock
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Stock>("MasayaNaturistCenterModel.FK__SaleDetai__idSto__3B75D760", "Stock").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Stock>("MasayaNaturistCenterModel.FK__SaleDetai__idSto__3B75D760", "Stock").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Stock> StockReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Stock>("MasayaNaturistCenterModel.FK__SaleDetai__idSto__3B75D760", "Stock");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Stock>("MasayaNaturistCenterModel.FK__SaleDetai__idSto__3B75D760", "Stock", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MasayaNaturistCenterModel", Name="Sell")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Sell : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Sell.
        /// </summary>
        /// <param name="idSell">Valor inicial de la propiedad idSell.</param>
        /// <param name="idEmployee">Valor inicial de la propiedad idEmployee.</param>
        /// <param name="date">Valor inicial de la propiedad date.</param>
        /// <param name="time">Valor inicial de la propiedad time.</param>
        /// <param name="total">Valor inicial de la propiedad total.</param>
        public static Sell CreateSell(global::System.Int32 idSell, global::System.Int32 idEmployee, global::System.String date, global::System.String time, global::System.Double total)
        {
            Sell sell = new Sell();
            sell.idSell = idSell;
            sell.idEmployee = idEmployee;
            sell.date = date;
            sell.time = time;
            sell.total = total;
            return sell;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idSell
        {
            get
            {
                return _idSell;
            }
            set
            {
                if (_idSell != value)
                {
                    OnidSellChanging(value);
                    ReportPropertyChanging("idSell");
                    _idSell = StructuralObject.SetValidValue(value, "idSell");
                    ReportPropertyChanged("idSell");
                    OnidSellChanged();
                }
            }
        }
        private global::System.Int32 _idSell;
        partial void OnidSellChanging(global::System.Int32 value);
        partial void OnidSellChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idEmployee
        {
            get
            {
                return _idEmployee;
            }
            set
            {
                OnidEmployeeChanging(value);
                ReportPropertyChanging("idEmployee");
                _idEmployee = StructuralObject.SetValidValue(value, "idEmployee");
                ReportPropertyChanged("idEmployee");
                OnidEmployeeChanged();
            }
        }
        private global::System.Int32 _idEmployee;
        partial void OnidEmployeeChanging(global::System.Int32 value);
        partial void OnidEmployeeChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String date
        {
            get
            {
                return _date;
            }
            set
            {
                OndateChanging(value);
                ReportPropertyChanging("date");
                _date = StructuralObject.SetValidValue(value, false, "date");
                ReportPropertyChanged("date");
                OndateChanged();
            }
        }
        private global::System.String _date;
        partial void OndateChanging(global::System.String value);
        partial void OndateChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String time
        {
            get
            {
                return _time;
            }
            set
            {
                OntimeChanging(value);
                ReportPropertyChanging("time");
                _time = StructuralObject.SetValidValue(value, false, "time");
                ReportPropertyChanged("time");
                OntimeChanged();
            }
        }
        private global::System.String _time;
        partial void OntimeChanging(global::System.String value);
        partial void OntimeChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double total
        {
            get
            {
                return _total;
            }
            set
            {
                OntotalChanging(value);
                ReportPropertyChanging("total");
                _total = StructuralObject.SetValidValue(value, "total");
                ReportPropertyChanged("total");
                OntotalChanged();
            }
        }
        private global::System.Double _total;
        partial void OntotalChanging(global::System.Double value);
        partial void OntotalChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Sell__idEmployee__2E1BDC42", "Employee")]
        public Employee Employee
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("MasayaNaturistCenterModel.FK__Sell__idEmployee__2E1BDC42", "Employee").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("MasayaNaturistCenterModel.FK__Sell__idEmployee__2E1BDC42", "Employee").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Employee> EmployeeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("MasayaNaturistCenterModel.FK__Sell__idEmployee__2E1BDC42", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Employee>("MasayaNaturistCenterModel.FK__Sell__idEmployee__2E1BDC42", "Employee", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__SaleDetai__idSel__3A81B327", "SaleDetail")]
        public EntityCollection<SaleDetail> SaleDetail
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<SaleDetail>("MasayaNaturistCenterModel.FK__SaleDetai__idSel__3A81B327", "SaleDetail");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<SaleDetail>("MasayaNaturistCenterModel.FK__SaleDetai__idSel__3A81B327", "SaleDetail", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MasayaNaturistCenterModel", Name="Stock")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Stock : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Stock.
        /// </summary>
        /// <param name="idStock">Valor inicial de la propiedad idStock.</param>
        /// <param name="idProduct">Valor inicial de la propiedad idProduct.</param>
        /// <param name="idPresentation">Valor inicial de la propiedad idPresentation.</param>
        /// <param name="quantity">Valor inicial de la propiedad quantity.</param>
        /// <param name="price">Valor inicial de la propiedad price.</param>
        public static Stock CreateStock(global::System.Int32 idStock, global::System.Int32 idProduct, global::System.Int32 idPresentation, global::System.Int32 quantity, global::System.Double price)
        {
            Stock stock = new Stock();
            stock.idStock = idStock;
            stock.idProduct = idProduct;
            stock.idPresentation = idPresentation;
            stock.quantity = quantity;
            stock.price = price;
            return stock;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idStock
        {
            get
            {
                return _idStock;
            }
            set
            {
                if (_idStock != value)
                {
                    OnidStockChanging(value);
                    ReportPropertyChanging("idStock");
                    _idStock = StructuralObject.SetValidValue(value, "idStock");
                    ReportPropertyChanged("idStock");
                    OnidStockChanged();
                }
            }
        }
        private global::System.Int32 _idStock;
        partial void OnidStockChanging(global::System.Int32 value);
        partial void OnidStockChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idProduct
        {
            get
            {
                return _idProduct;
            }
            set
            {
                OnidProductChanging(value);
                ReportPropertyChanging("idProduct");
                _idProduct = StructuralObject.SetValidValue(value, "idProduct");
                ReportPropertyChanged("idProduct");
                OnidProductChanged();
            }
        }
        private global::System.Int32 _idProduct;
        partial void OnidProductChanging(global::System.Int32 value);
        partial void OnidProductChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idPresentation
        {
            get
            {
                return _idPresentation;
            }
            set
            {
                OnidPresentationChanging(value);
                ReportPropertyChanging("idPresentation");
                _idPresentation = StructuralObject.SetValidValue(value, "idPresentation");
                ReportPropertyChanged("idPresentation");
                OnidPresentationChanged();
            }
        }
        private global::System.Int32 _idPresentation;
        partial void OnidPresentationChanging(global::System.Int32 value);
        partial void OnidPresentationChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                OnquantityChanging(value);
                ReportPropertyChanging("quantity");
                _quantity = StructuralObject.SetValidValue(value, "quantity");
                ReportPropertyChanged("quantity");
                OnquantityChanged();
            }
        }
        private global::System.Int32 _quantity;
        partial void OnquantityChanging(global::System.Int32 value);
        partial void OnquantityChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double price
        {
            get
            {
                return _price;
            }
            set
            {
                OnpriceChanging(value);
                ReportPropertyChanging("price");
                _price = StructuralObject.SetValidValue(value, "price");
                ReportPropertyChanged("price");
                OnpriceChanged();
            }
        }
        private global::System.Double _price;
        partial void OnpriceChanging(global::System.Double value);
        partial void OnpriceChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String entryDate
        {
            get
            {
                return _entryDate;
            }
            set
            {
                OnentryDateChanging(value);
                ReportPropertyChanging("entryDate");
                _entryDate = StructuralObject.SetValidValue(value, true, "entryDate");
                ReportPropertyChanged("entryDate");
                OnentryDateChanged();
            }
        }
        private global::System.String _entryDate;
        partial void OnentryDateChanging(global::System.String value);
        partial void OnentryDateChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String expiration
        {
            get
            {
                return _expiration;
            }
            set
            {
                OnexpirationChanging(value);
                ReportPropertyChanging("expiration");
                _expiration = StructuralObject.SetValidValue(value, true, "expiration");
                ReportPropertyChanged("expiration");
                OnexpirationChanged();
            }
        }
        private global::System.String _expiration;
        partial void OnexpirationChanging(global::System.String value);
        partial void OnexpirationChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Stock__idPresent__37A5467C", "Presentation")]
        public Presentation Presentation
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Presentation>("MasayaNaturistCenterModel.FK__Stock__idPresent__37A5467C", "Presentation").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Presentation>("MasayaNaturistCenterModel.FK__Stock__idPresent__37A5467C", "Presentation").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Presentation> PresentationReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Presentation>("MasayaNaturistCenterModel.FK__Stock__idPresent__37A5467C", "Presentation");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Presentation>("MasayaNaturistCenterModel.FK__Stock__idPresent__37A5467C", "Presentation", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Stock__idProduct__36B12243", "Product")]
        public Product Product
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("MasayaNaturistCenterModel.FK__Stock__idProduct__36B12243", "Product").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("MasayaNaturistCenterModel.FK__Stock__idProduct__36B12243", "Product").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Product> ProductReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("MasayaNaturistCenterModel.FK__Stock__idProduct__36B12243", "Product");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Product>("MasayaNaturistCenterModel.FK__Stock__idProduct__36B12243", "Product", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__SaleDetai__idSto__3B75D760", "SaleDetail")]
        public EntityCollection<SaleDetail> SaleDetail
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<SaleDetail>("MasayaNaturistCenterModel.FK__SaleDetai__idSto__3B75D760", "SaleDetail");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<SaleDetail>("MasayaNaturistCenterModel.FK__SaleDetai__idSto__3B75D760", "SaleDetail", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__SupplyDet__idSto__3F466844", "SupplyDetail")]
        public EntityCollection<SupplyDetail> SupplyDetail
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<SupplyDetail>("MasayaNaturistCenterModel.FK__SupplyDet__idSto__3F466844", "SupplyDetail");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<SupplyDetail>("MasayaNaturistCenterModel.FK__SupplyDet__idSto__3F466844", "SupplyDetail", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MasayaNaturistCenterModel", Name="Supply")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Supply : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Supply.
        /// </summary>
        /// <param name="idSupply">Valor inicial de la propiedad idSupply.</param>
        /// <param name="idProvider">Valor inicial de la propiedad idProvider.</param>
        /// <param name="date">Valor inicial de la propiedad date.</param>
        /// <param name="time">Valor inicial de la propiedad time.</param>
        /// <param name="total">Valor inicial de la propiedad total.</param>
        public static Supply CreateSupply(global::System.Int32 idSupply, global::System.Int32 idProvider, global::System.String date, global::System.String time, global::System.Double total)
        {
            Supply supply = new Supply();
            supply.idSupply = idSupply;
            supply.idProvider = idProvider;
            supply.date = date;
            supply.time = time;
            supply.total = total;
            return supply;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idSupply
        {
            get
            {
                return _idSupply;
            }
            set
            {
                if (_idSupply != value)
                {
                    OnidSupplyChanging(value);
                    ReportPropertyChanging("idSupply");
                    _idSupply = StructuralObject.SetValidValue(value, "idSupply");
                    ReportPropertyChanged("idSupply");
                    OnidSupplyChanged();
                }
            }
        }
        private global::System.Int32 _idSupply;
        partial void OnidSupplyChanging(global::System.Int32 value);
        partial void OnidSupplyChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idProvider
        {
            get
            {
                return _idProvider;
            }
            set
            {
                OnidProviderChanging(value);
                ReportPropertyChanging("idProvider");
                _idProvider = StructuralObject.SetValidValue(value, "idProvider");
                ReportPropertyChanged("idProvider");
                OnidProviderChanged();
            }
        }
        private global::System.Int32 _idProvider;
        partial void OnidProviderChanging(global::System.Int32 value);
        partial void OnidProviderChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String date
        {
            get
            {
                return _date;
            }
            set
            {
                OndateChanging(value);
                ReportPropertyChanging("date");
                _date = StructuralObject.SetValidValue(value, false, "date");
                ReportPropertyChanged("date");
                OndateChanged();
            }
        }
        private global::System.String _date;
        partial void OndateChanging(global::System.String value);
        partial void OndateChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String time
        {
            get
            {
                return _time;
            }
            set
            {
                OntimeChanging(value);
                ReportPropertyChanging("time");
                _time = StructuralObject.SetValidValue(value, false, "time");
                ReportPropertyChanged("time");
                OntimeChanged();
            }
        }
        private global::System.String _time;
        partial void OntimeChanging(global::System.String value);
        partial void OntimeChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double total
        {
            get
            {
                return _total;
            }
            set
            {
                OntotalChanging(value);
                ReportPropertyChanging("total");
                _total = StructuralObject.SetValidValue(value, "total");
                ReportPropertyChanged("total");
                OntotalChanged();
            }
        }
        private global::System.Double _total;
        partial void OntotalChanging(global::System.Double value);
        partial void OntotalChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__Supply__idProvid__30F848ED", "Provider")]
        public Provider Provider
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Provider>("MasayaNaturistCenterModel.FK__Supply__idProvid__30F848ED", "Provider").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Provider>("MasayaNaturistCenterModel.FK__Supply__idProvid__30F848ED", "Provider").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Provider> ProviderReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Provider>("MasayaNaturistCenterModel.FK__Supply__idProvid__30F848ED", "Provider");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Provider>("MasayaNaturistCenterModel.FK__Supply__idProvid__30F848ED", "Provider", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__SupplyDet__idSup__3E52440B", "SupplyDetail")]
        public EntityCollection<SupplyDetail> SupplyDetail
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<SupplyDetail>("MasayaNaturistCenterModel.FK__SupplyDet__idSup__3E52440B", "SupplyDetail");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<SupplyDetail>("MasayaNaturistCenterModel.FK__SupplyDet__idSup__3E52440B", "SupplyDetail", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MasayaNaturistCenterModel", Name="SupplyDetail")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class SupplyDetail : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto SupplyDetail.
        /// </summary>
        /// <param name="idSupplyDetail">Valor inicial de la propiedad idSupplyDetail.</param>
        /// <param name="idSupply">Valor inicial de la propiedad idSupply.</param>
        /// <param name="idStock">Valor inicial de la propiedad idStock.</param>
        /// <param name="quantity">Valor inicial de la propiedad quantity.</param>
        /// <param name="price">Valor inicial de la propiedad price.</param>
        /// <param name="total">Valor inicial de la propiedad total.</param>
        public static SupplyDetail CreateSupplyDetail(global::System.Int32 idSupplyDetail, global::System.Int32 idSupply, global::System.Int32 idStock, global::System.Int32 quantity, global::System.Double price, global::System.Double total)
        {
            SupplyDetail supplyDetail = new SupplyDetail();
            supplyDetail.idSupplyDetail = idSupplyDetail;
            supplyDetail.idSupply = idSupply;
            supplyDetail.idStock = idStock;
            supplyDetail.quantity = quantity;
            supplyDetail.price = price;
            supplyDetail.total = total;
            return supplyDetail;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idSupplyDetail
        {
            get
            {
                return _idSupplyDetail;
            }
            set
            {
                if (_idSupplyDetail != value)
                {
                    OnidSupplyDetailChanging(value);
                    ReportPropertyChanging("idSupplyDetail");
                    _idSupplyDetail = StructuralObject.SetValidValue(value, "idSupplyDetail");
                    ReportPropertyChanged("idSupplyDetail");
                    OnidSupplyDetailChanged();
                }
            }
        }
        private global::System.Int32 _idSupplyDetail;
        partial void OnidSupplyDetailChanging(global::System.Int32 value);
        partial void OnidSupplyDetailChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idSupply
        {
            get
            {
                return _idSupply;
            }
            set
            {
                OnidSupplyChanging(value);
                ReportPropertyChanging("idSupply");
                _idSupply = StructuralObject.SetValidValue(value, "idSupply");
                ReportPropertyChanged("idSupply");
                OnidSupplyChanged();
            }
        }
        private global::System.Int32 _idSupply;
        partial void OnidSupplyChanging(global::System.Int32 value);
        partial void OnidSupplyChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idStock
        {
            get
            {
                return _idStock;
            }
            set
            {
                OnidStockChanging(value);
                ReportPropertyChanging("idStock");
                _idStock = StructuralObject.SetValidValue(value, "idStock");
                ReportPropertyChanged("idStock");
                OnidStockChanged();
            }
        }
        private global::System.Int32 _idStock;
        partial void OnidStockChanging(global::System.Int32 value);
        partial void OnidStockChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                OnquantityChanging(value);
                ReportPropertyChanging("quantity");
                _quantity = StructuralObject.SetValidValue(value, "quantity");
                ReportPropertyChanged("quantity");
                OnquantityChanged();
            }
        }
        private global::System.Int32 _quantity;
        partial void OnquantityChanging(global::System.Int32 value);
        partial void OnquantityChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double price
        {
            get
            {
                return _price;
            }
            set
            {
                OnpriceChanging(value);
                ReportPropertyChanging("price");
                _price = StructuralObject.SetValidValue(value, "price");
                ReportPropertyChanged("price");
                OnpriceChanged();
            }
        }
        private global::System.Double _price;
        partial void OnpriceChanging(global::System.Double value);
        partial void OnpriceChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double total
        {
            get
            {
                return _total;
            }
            set
            {
                OntotalChanging(value);
                ReportPropertyChanging("total");
                _total = StructuralObject.SetValidValue(value, "total");
                ReportPropertyChanged("total");
                OntotalChanged();
            }
        }
        private global::System.Double _total;
        partial void OntotalChanging(global::System.Double value);
        partial void OntotalChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__SupplyDet__idSto__3F466844", "Stock")]
        public Stock Stock
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Stock>("MasayaNaturistCenterModel.FK__SupplyDet__idSto__3F466844", "Stock").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Stock>("MasayaNaturistCenterModel.FK__SupplyDet__idSto__3F466844", "Stock").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Stock> StockReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Stock>("MasayaNaturistCenterModel.FK__SupplyDet__idSto__3F466844", "Stock");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Stock>("MasayaNaturistCenterModel.FK__SupplyDet__idSto__3F466844", "Stock", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MasayaNaturistCenterModel", "FK__SupplyDet__idSup__3E52440B", "Supply")]
        public Supply Supply
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Supply>("MasayaNaturistCenterModel.FK__SupplyDet__idSup__3E52440B", "Supply").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Supply>("MasayaNaturistCenterModel.FK__SupplyDet__idSup__3E52440B", "Supply").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Supply> SupplyReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Supply>("MasayaNaturistCenterModel.FK__SupplyDet__idSup__3E52440B", "Supply");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Supply>("MasayaNaturistCenterModel.FK__SupplyDet__idSup__3E52440B", "Supply", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
