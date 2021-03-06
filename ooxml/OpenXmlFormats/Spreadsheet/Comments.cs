// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>schemas</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace NPOI.OpenXmlFormats.Spreadsheet
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// The Comments part of the Spreadsheets.
    /// </summary>
    [Serializable]
    //[System.Diagnostics.DebuggerStepThrough]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main",
        ElementName = "comments")]
    public class CT_Comments
    {
        private CT_Authors authorsField = new CT_Authors(); // required field

        private CT_CommentList commentListField = new CT_CommentList(); // required field

        private CT_ExtensionList extLstField = null; // optional field

        //public CT_Comments()
        //{
        //    this.extLstField = new CT_ExtensionList();
        //    this.commentListField = new CT_CommentList();
        //    this.authorsField = new CT_Authors();
        //}
        public CT_Authors AddNewAuthors()
        {
            this.authorsField = new CT_Authors();
            return this.authorsField;
        }
        public void AddNewCommentList()
        {
            this.commentListField = new CT_CommentList();
        }

        [XmlElement("authors", Order = 0)]
        public CT_Authors authors
        {
            get
            {
                return this.authorsField;
            }
            set
            {
                this.authorsField = value;
            }
        }
        [XmlElement("commentList", Order = 1)]
        public CT_CommentList commentList
        {
            get
            {
                return this.commentListField;
            }
            set
            {
                this.commentListField = value;
            }
        }

        [XmlElement("extLst", Order = 2)]
        public CT_ExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }
    }

    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main",
        ElementName = "comment")]
    public class CT_Comment
    {

        private CT_Rst textField = new CT_Rst(); // required element 

        private string refField = string.Empty; // required attribute

        private uint authorIdField = 0; // required attribute

        private string guidField = null; // optional attribute

        //public CT_Comment()
        //{
        //    this.textField = new CT_Rst();
        //}

        [XmlElement("text")]
        public CT_Rst text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        [XmlAttribute("ref")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }

        [XmlAttribute("authorId")]
        public uint authorId
        {
            get
            {
                return this.authorIdField;
            }
            set
            {
                this.authorIdField = value;
            }
        }

        [XmlAttribute("guid")] // 0..1 TODO: Type is ST_Guid
        public string guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }
    }

    [Serializable]
   // [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    // not needed because it not used as a root [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", ElementName = "authors")]
    public class CT_Authors
    {

        private List<string> authorField = null; // optional field [0..*]

        //public CT_Authors()
        //{
        //    this.authorField = new List<string>();
        //}
        public int SizeOfAuthorArray()
        {
            return (null == authorField) ? 0 : authorField.Count;
        }
        public string GetAuthorArray(int index)
        {
            return (null == authorField) ? null : authorField[index];
        }
        public void Insert(int index, string author)
        {
            if (null == authorField) { authorField = new List<string>(); }
            authorField.Insert(index, author);
        }
        public void AddAuthor(string name)
        {
            if (null == authorField) { authorField = new List<string>(); }
            authorField.Add(name);
        }
        //[XmlArray("authors", Order = 0)] // - encapsulates the following items, but the outer element already provides the container.
        //[XmlArrayItem("author")]
        [XmlElement("author")] // this is serialized into multiple author entries
        public List<string> author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }
    }

    [Serializable]
    //[XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_CommentList
    {

        private List<CT_Comment> commentField = null; // optional field [0..*]

        //public CT_CommentList()
        //{
        //    this.commentField = new List<CT_Comment>();
        //}

        public CT_Comment GetCommentArray(int index)
        {
            return comment[index];
        }
        public void RemoveComment(int index)
        {
            comment.RemoveAt(index);
        }
        public int SizeOfCommentArray()
        {
            return comment.Count;
        }
        public CT_Comment InsertNewComment(int index)
        {
            if (null == commentField) { commentField = new List<CT_Comment>(); }
            CT_Comment com = new CT_Comment();
            commentField.Insert(index,com);
            return com;            
        }
        public CT_Comment AddNewComment()
        {
            if (null == commentField) { commentField = new List<CT_Comment>(); }
            CT_Comment com= new CT_Comment();
            commentField.Add(com);
            return com;
        }

        [XmlElement("comment")]
        public List<CT_Comment> comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }
    }
}
