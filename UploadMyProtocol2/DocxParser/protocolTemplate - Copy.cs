namespace Aztech
{
    using System;
    using System.Collections.Generic;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.appvizo.com/aztech/protocol")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.appvizo.com/aztech/protocol", IsNullable = false)]
    public partial class AzProtocol
    {

        //public AzProtocol()
        //{
        //    this.SpeciesList = new AzProtocolSpeciesList();
        //}

        //[System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
        //[System.SerializableAttribute()]
        //[System.ComponentModel.DesignerCategoryAttribute("code")]
        //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.appvizo.com/aztech/protocol")]
        //public class AzProtocolSpeciesList
        //{
        //    public AzProtocolSpeciesList() { Items = new List<AzProtocolSpecies>(); }

        //    //[System.Xml.Serialization.XmlArrayItemAttribute("speciesList", IsNullable = false)]
        //    public List<AzProtocolSpecies> Items { get; set; }
        //}

          /// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("speciesList")]
        //public AzProtocolSpeciesList SpeciesList { get; set; }
        [System.Xml.Serialization.XmlArrayItemAttribute("speciesList", IsNullable = false)]
        public List<AzProtocolSpecies> SpeciesList { get; set; }
  

        private AzProtocolInvestigator investigatorField;

        private string laySummaryField;

        private string aimsField;

        private string collaborationField;

        private string animalTissueField;

        private string experimentalDesignField;

        private string biohazardsField;

        private string drugsField;

        private string euthanasiaMethodsField;

        private List<AzProtocolFundingSource> fundingSourcesField;

        private List<AzProtocolSurgery> surgeryListField;

        private List<AzProtocolPerson> personnelField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("protocolID")]
        public string ProtocolID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("title")]
        public string Title { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("investigator")]
        public AzProtocolInvestigator Investigator
        {
            get
            {
                return this.investigatorField;
            }
            set
            {
                this.investigatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("laySummary")]
        public string LaySummary
        {
            get
            {
                return this.laySummaryField;
            }
            set
            {
                this.laySummaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("aims")]
        public string Aims
        {
            get
            {
                return this.aimsField;
            }
            set
            {
                this.aimsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("collaboration")]
        public string Collaboration
        {
            get
            {
                return this.collaborationField;
            }
            set
            {
                this.collaborationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("animalTissue")]
        public string AnimalTissue
        {
            get
            {
                return this.animalTissueField;
            }
            set
            {
                this.animalTissueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("experimentalDesign")]
        public string ExperimentalDesign
        {
            get
            {
                return this.experimentalDesignField;
            }
            set
            {
                this.experimentalDesignField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("biohazards")]
        public string Biohazards
        {
            get
            {
                return this.biohazardsField;
            }
            set
            {
                this.biohazardsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("drugs")]
        public string Drugs
        {
            get
            {
                return this.drugsField;
            }
            set
            {
                this.drugsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("euthanasiaMethods")]
        public string EuthanasiaMethods
        {
            get
            {
                return this.euthanasiaMethodsField;
            }
            set
            {
                this.euthanasiaMethodsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fundingSource", IsNullable = false)]
        public List<AzProtocolFundingSource> FundingSources
        {
            get
            {
                return this.fundingSourcesField;
            }
            set
            {
                this.fundingSourcesField = value;
            }
        }

      

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("surgery", IsNullable = false)]
        public List<AzProtocolSurgery> SurgeryList
        {
            get
            {
                return this.surgeryListField;
            }
            set
            {
                this.surgeryListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("person", IsNullable = false)]
        public List<AzProtocolPerson> Personnel
        {
            get
            {
                return this.personnelField;
            }
            set
            {
                this.personnelField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.appvizo.com/aztech/protocol")]
    public partial class AzProtocolInvestigator
    {

        private bool primaryField;

        private string nameField;

        private string phoneField;

        private string emailField;

        private string alternateNameField;

        private string alternatePhoneField;

        private string alternateEmailField;

        public AzProtocolInvestigator()
        {
            this.primaryField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("primary")]
        public bool Primary
        {
            get
            {
                return this.primaryField;
            }
            set
            {
                this.primaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("phone")]
        public string Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("email")]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("alternateName")]
        public string AlternateName
        {
            get
            {
                return this.alternateNameField;
            }
            set
            {
                this.alternateNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("alternatePhone")]
        public string AlternatePhone
        {
            get
            {
                return this.alternatePhoneField;
            }
            set
            {
                this.alternatePhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("alternateEmail")]
        public string AlternateEmail
        {
            get
            {
                return this.alternateEmailField;
            }
            set
            {
                this.alternateEmailField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.appvizo.com/aztech/protocol")]
    public partial class AzProtocolFundingSource
    {

        private string fundTypeField;

        private string fundNameField;

        private string fundTitleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fundType")]
        public string FundType
        {
            get
            {
                return this.fundTypeField;
            }
            set
            {
                this.fundTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fundName")]
        public string FundName
        {
            get
            {
                return this.fundNameField;
            }
            set
            {
                this.fundNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fundTitle")]
        public string FundTitle
        {
            get
            {
                return this.fundTitleField;
            }
            set
            {
                this.fundTitleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.appvizo.com/aztech/protocol")]
    public partial class AzProtocolSpecies
    {

        public AzProtocolSpecies()
        {
            this.SpeciesNumber = "0";
            this.PainCategory = "B";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("speciesName")]
        public string SpeciesName { get; set; }

        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute("0")]
        [System.Xml.Serialization.XmlElementAttribute("speciesNumber")]
        public string SpeciesNumber { get; set; }

        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute("B")]
        [System.Xml.Serialization.XmlElementAttribute("painCategory")]
        public string PainCategory { get; set; }

        /// <remarks/>
        public bool SurvivalSurgery { get; set; }

        /// <remarks/>
        public bool ProlongedRestraint { get; set; }

        /// <remarks/>
        public bool MultipleMajorSurgeries { get; set; }

        /// <remarks/>
        public bool HazardousAgents { get; set; }

        /// <remarks/>
        public bool FoodFluidRestrictions { get; set; }

        /// <remarks/>
        public bool NoncentralizedAreas { get; set; }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.appvizo.com/aztech/protocol")]
    public partial class AzProtocolSurgery
    {

        private string speciesNameField;

        private string surgeryTypeField;

        private string classificationField;

        private string procedureField;

        private List<AzProtocolSurgeryLocation> locationsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("speciesName")]
        public string SpeciesName
        {
            get
            {
                return this.speciesNameField;
            }
            set
            {
                this.speciesNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("surgeryType")]
        public string SurgeryType
        {
            get
            {
                return this.surgeryTypeField;
            }
            set
            {
                this.surgeryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("classification")]
        public string Classification
        {
            get
            {
                return this.classificationField;
            }
            set
            {
                this.classificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("procedure")]
        public string Procedure
        {
            get
            {
                return this.procedureField;
            }
            set
            {
                this.procedureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("location", IsNullable = false)]
        public List<AzProtocolSurgeryLocation> Locations
        {
            get
            {
                return this.locationsField;
            }
            set
            {
                this.locationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.appvizo.com/aztech/protocol")]
    public partial class AzProtocolSurgeryLocation
    {

        private string buildingField;

        private string roomField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("building")]
        public string Building
        {
            get
            {
                return this.buildingField;
            }
            set
            {
                this.buildingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("room")]
        public string Room
        {
            get
            {
                return this.roomField;
            }
            set
            {
                this.roomField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.appvizo.com/aztech/protocol")]
    public partial class AzProtocolPerson
    {

        private string fullNameField;

        private string emailField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fullName")]
        public string FullName
        {
            get
            {
                return this.fullNameField;
            }
            set
            {
                this.fullNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("email")]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.appvizo.com/aztech/protocol")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.appvizo.com/aztech/protocol", IsNullable = false)]
    public partial class ProtocolDataSet
    {

        private AzProtocol itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AzProtocol")]
        public AzProtocol Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
}
