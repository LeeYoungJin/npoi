// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>schemas</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace NPOI.OpenXmlFormats
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties")]
    [XmlRoot("Properties", Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties", IsNullable = true)]
    public class CT_ExtendedProperties
    {

        private string templateField;

        private string managerField;

        private string companyField;

        private int pagesField;

        private bool pagesFieldSpecified;

        private int wordsField;

        private bool wordsFieldSpecified;

        private int charactersField;

        private bool charactersFieldSpecified;

        private string presentationFormatField;

        private int linesField;

        private bool linesFieldSpecified;

        private int paragraphsField;

        private bool paragraphsFieldSpecified;

        private int slidesField;

        private bool slidesFieldSpecified;

        private int notesField;

        private bool notesFieldSpecified;

        private int totalTimeField;

        private bool totalTimeFieldSpecified;

        private int hiddenSlidesField;

        private bool hiddenSlidesFieldSpecified;

        private int mMClipsField;

        private bool mMClipsFieldSpecified;

        private bool scaleCropField;

        private bool scaleCropFieldSpecified;

        private CT_VectorVariant headingPairsField;

        private CT_VectorLpstr titlesOfPartsField;

        private bool linksUpToDateField;

        private bool linksUpToDateFieldSpecified;

        private int charactersWithSpacesField;

        private bool charactersWithSpacesFieldSpecified;

        private bool sharedDocField;

        private bool sharedDocFieldSpecified;

        private string hyperlinkBaseField;

        private CT_VectorVariant hLinksField;

        private bool hyperlinksChangedField;

        private bool hyperlinksChangedFieldSpecified;

        private CT_DigSigBlob digSigField;

        private string applicationField;

        private string appVersionField;

        private int docSecurityField;

        private bool docSecurityFieldSpecified;
        [XmlElement]
    
        public string Template
        {
            get
            {
                return this.templateField;
            }
            set
            {
                this.templateField = value;
            }
        }
        [XmlElement]
    
        public string Manager
        {
            get
            {
                return this.managerField;
            }
            set
            {
                this.managerField = value;
            }
        }
        [XmlElement]
    
        public string Company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }
        [XmlElement]
    
        public int Pages
        {
            get
            {
                return this.pagesField;
            }
            set
            {
                this.pagesField = value;
            }
        }

    
        [XmlIgnore]
        public bool PagesSpecified
        {
            get
            {
                return this.pagesFieldSpecified;
            }
            set
            {
                this.pagesFieldSpecified = value;
            }
        }
        [XmlElement]
    
        public int Words
        {
            get
            {
                return this.wordsField;
            }
            set
            {
                this.wordsField = value;
            }
        }

    
        [XmlIgnore]
        public bool WordsSpecified
        {
            get
            {
                return this.wordsFieldSpecified;
            }
            set
            {
                this.wordsFieldSpecified = value;
            }
        }
        [XmlElement]
    
        public int Characters
        {
            get
            {
                return this.charactersField;
            }
            set
            {
                this.charactersField = value;
            }
        }

    
        [XmlIgnore]
        public bool CharactersSpecified
        {
            get
            {
                return this.charactersFieldSpecified;
            }
            set
            {
                this.charactersFieldSpecified = value;
            }
        }
        [XmlElement]
    
        public string PresentationFormat
        {
            get
            {
                return this.presentationFormatField;
            }
            set
            {
                this.presentationFormatField = value;
            }
        }
        [XmlElement]
    
        public int Lines
        {
            get
            {
                return this.linesField;
            }
            set
            {
                this.linesField = value;
            }
        }

    
        [XmlIgnore]
        public bool LinesSpecified
        {
            get
            {
                return this.linesFieldSpecified;
            }
            set
            {
                this.linesFieldSpecified = value;
            }
        }
        [XmlElement]
    
        public int Paragraphs
        {
            get
            {
                return this.paragraphsField;
            }
            set
            {
                this.paragraphsField = value;
            }
        }

    
        [XmlIgnore]
        public bool ParagraphsSpecified
        {
            get
            {
                return this.paragraphsFieldSpecified;
            }
            set
            {
                this.paragraphsFieldSpecified = value;
            }
        }
        [XmlElement]
    
        public int Slides
        {
            get
            {
                return this.slidesField;
            }
            set
            {
                this.slidesField = value;
            }
        }

    
        [XmlIgnore]
        public bool SlidesSpecified
        {
            get
            {
                return this.slidesFieldSpecified;
            }
            set
            {
                this.slidesFieldSpecified = value;
            }
        }
        [XmlElement]
    
        public int Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

    
        [XmlIgnore]
        public bool NotesSpecified
        {
            get
            {
                return this.notesFieldSpecified;
            }
            set
            {
                this.notesFieldSpecified = value;
            }
        }
        [XmlElement]
    
        public int TotalTime
        {
            get
            {
                return this.totalTimeField;
            }
            set
            {
                this.totalTimeField = value;
            }
        }

    
        [XmlIgnore]
        public bool TotalTimeSpecified
        {
            get
            {
                return this.totalTimeFieldSpecified;
            }
            set
            {
                this.totalTimeFieldSpecified = value;
            }
        }
        [XmlElement]
    
        public int HiddenSlides
        {
            get
            {
                return this.hiddenSlidesField;
            }
            set
            {
                this.hiddenSlidesField = value;
            }
        }

    
        [XmlIgnore]
        public bool HiddenSlidesSpecified
        {
            get
            {
                return this.hiddenSlidesFieldSpecified;
            }
            set
            {
                this.hiddenSlidesFieldSpecified = value;
            }
        }
        [XmlElement]
    
        public int MMClips
        {
            get
            {
                return this.mMClipsField;
            }
            set
            {
                this.mMClipsField = value;
            }
        }

    
        [XmlIgnore]
        public bool MMClipsSpecified
        {
            get
            {
                return this.mMClipsFieldSpecified;
            }
            set
            {
                this.mMClipsFieldSpecified = value;
            }
        }
        [XmlElement]
        public bool ScaleCrop
        {
            get
            {
                return this.scaleCropField;
            }
            set
            {
                this.scaleCropField = value;
            }
        }

    
        [XmlIgnore]
        public bool ScaleCropSpecified
        {
            get
            {
                return this.scaleCropFieldSpecified;
            }
            set
            {
                this.scaleCropFieldSpecified = value;
            }
        }

        [XmlElement]
        public CT_VectorVariant HeadingPairs
        {
            get
            {
                return this.headingPairsField;
            }
            set
            {
                this.headingPairsField = value;
            }
        }

        [XmlElement]
        public CT_VectorLpstr TitlesOfParts
        {
            get
            {
                return this.titlesOfPartsField;
            }
            set
            {
                this.titlesOfPartsField = value;
            }
        }
        [XmlElement]
    
        public bool LinksUpToDate
        {
            get
            {
                return this.linksUpToDateField;
            }
            set
            {
                this.linksUpToDateField = value;
            }
        }

    
        [XmlIgnore]
        public bool LinksUpToDateSpecified
        {
            get
            {
                return this.linksUpToDateFieldSpecified;
            }
            set
            {
                this.linksUpToDateFieldSpecified = value;
            }
        }
        [XmlElement]
    
        public int CharactersWithSpaces
        {
            get
            {
                return this.charactersWithSpacesField;
            }
            set
            {
                this.charactersWithSpacesField = value;
            }
        }

    
        [XmlIgnore]
        public bool CharactersWithSpacesSpecified
        {
            get
            {
                return this.charactersWithSpacesFieldSpecified;
            }
            set
            {
                this.charactersWithSpacesFieldSpecified = value;
            }
        }
        [XmlElement]
    
        public bool SharedDoc
        {
            get
            {
                return this.sharedDocField;
            }
            set
            {
                this.sharedDocField = value;
            }
        }

    
        [XmlIgnore]
        public bool SharedDocSpecified
        {
            get
            {
                return this.sharedDocFieldSpecified;
            }
            set
            {
                this.sharedDocFieldSpecified = value;
            }
        }
        [XmlElement]
    
        public string HyperlinkBase
        {
            get
            {
                return this.hyperlinkBaseField;
            }
            set
            {
                this.hyperlinkBaseField = value;
            }
        }

    
        public CT_VectorVariant HLinks
        {
            get
            {
                return this.hLinksField;
            }
            set
            {
                this.hLinksField = value;
            }
        }
        [XmlElement]
    
        public bool HyperlinksChanged
        {
            get
            {
                return this.hyperlinksChangedField;
            }
            set
            {
                this.hyperlinksChangedField = value;
            }
        }
    
        [XmlIgnore]
        public bool HyperlinksChangedSpecified
        {
            get
            {
                return this.hyperlinksChangedFieldSpecified;
            }
            set
            {
                this.hyperlinksChangedFieldSpecified = value;
            }
        }

        [XmlElement]
        public CT_DigSigBlob DigSig
        {
            get
            {
                return this.digSigField;
            }
            set
            {
                this.digSigField = value;
            }
        }

        [XmlElement]
    
        public string Application
        {
            get
            {
                return this.applicationField;
            }
            set
            {
                this.applicationField = value;
            }
        }
        [XmlElement]
    
        public string AppVersion
        {
            get
            {
                return this.appVersionField;
            }
            set
            {
                this.appVersionField = value;
            }
        }
        [XmlElement]
    
        public int DocSecurity
        {
            get
            {
                return this.docSecurityField;
            }
            set
            {
                this.docSecurityField = value;
            }
        }

    
        [XmlIgnore]
        public bool DocSecuritySpecified
        {
            get
            {
                return this.docSecurityFieldSpecified;
            }
            set
            {
                this.docSecurityFieldSpecified = value;
            }
        }
        public CT_ExtendedProperties Copy()
        {
            CT_ExtendedProperties prop = new CT_ExtendedProperties();
            prop.applicationField = this.applicationField;
            prop.appVersionField = this.appVersionField;
            prop.charactersField = this.charactersField;
            prop.charactersWithSpacesField = this.charactersWithSpacesField;
            prop.companyField = this.companyField;
            prop.digSigField = this.digSigField;
            prop.docSecurityField = this.docSecurityField;
            prop.headingPairsField = this.headingPairsField;
            prop.hiddenSlidesField = this.hiddenSlidesField;
            prop.hLinksField = this.hLinksField;
            prop.hyperlinkBaseField = this.hyperlinkBaseField;
            prop.hyperlinksChangedField = this.hyperlinksChangedField;
            prop.hyperlinksChangedFieldSpecified = this.hyperlinksChangedFieldSpecified;
            prop.linesField = this.linesField;
            prop.linksUpToDateFieldSpecified = this.linksUpToDateFieldSpecified;
            prop.linksUpToDateField = this.linksUpToDateField;
            prop.managerField = this.managerField;
            prop.mMClipsField = this.mMClipsField;
            prop.mMClipsFieldSpecified = this.mMClipsFieldSpecified;
            prop.notesField = this.notesField;
            prop.notesFieldSpecified = this.notesFieldSpecified;
            prop.pagesField = this.pagesField;
            prop.pagesFieldSpecified = this.pagesFieldSpecified;
            prop.paragraphsField = this.paragraphsField;
            prop.paragraphsFieldSpecified = this.paragraphsFieldSpecified;
            prop.presentationFormatField = this.presentationFormatField;
            prop.scaleCropField = this.scaleCropField;
            prop.scaleCropFieldSpecified = this.scaleCropFieldSpecified;
            prop.sharedDocField = this.sharedDocField;
            prop.sharedDocFieldSpecified = this.sharedDocFieldSpecified;
            prop.slidesField = this.slidesField;
            prop.templateField = this.templateField;
            prop.titlesOfPartsField = this.titlesOfPartsField;
            prop.totalTimeField = this.totalTimeField;
            prop.totalTimeFieldSpecified = this.totalTimeFieldSpecified;
            prop.wordsField = this.wordsField;
            return prop;
        }
    }

    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties", IsNullable = true)]
    public class CT_VectorVariant
    {

        private CT_Vector vectorField;

        public CT_VectorVariant()
        {
            //this.vectorField = new CT_Vector();
        }
        [XmlElement]
        public CT_Vector vector
        {
            get
            {
                return this.vectorField;
            }
            set
            {
                this.vectorField = value;
            }
        }
    }

    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties", IsNullable = true)]

    public class CT_DigSigBlob
    {

        private byte[] blobField;
        [XmlElement(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", DataType = "base64Binary")]
        public byte[] blob
        {
            get
            {
                return this.blobField;
            }
            set
            {
                this.blobField = value;
            }
        }
    }

    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties", IsNullable = true)]
    public class CT_VectorLpstr
    {

        private CT_Vector vectorField;

        public CT_VectorLpstr()
        {
            this.vectorField = new CT_Vector();
        }
        [XmlElement(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
        public CT_Vector vector
        {
            get
            {
                return this.vectorField;
            }
            set
            {
                this.vectorField = value;
            }
        }
    }


 
 
}
