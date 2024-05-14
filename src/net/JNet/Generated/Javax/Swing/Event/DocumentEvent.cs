/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Event
{
    #region IDocumentEvent
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDocumentEvent
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.html#getDocument()"/> 
        /// </summary>
        Javax.Swing.Text.Document Document { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.html#getLength()"/> 
        /// </summary>
        int Length { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.html#getOffset()"/> 
        /// </summary>
        int Offset { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.html#getType()"/> 
        /// </summary>
        Javax.Swing.Event.DocumentEvent.EventType Type { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.html#getChange(javax.swing.text.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        /// <returns><see cref="Javax.Swing.Event.DocumentEvent.ElementChange"/></returns>
        Javax.Swing.Event.DocumentEvent.ElementChange GetChange(Javax.Swing.Text.Element arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DocumentEvent
    public partial class DocumentEvent : Javax.Swing.Event.IDocumentEvent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.html#getDocument()"/> 
        /// </summary>
        public Javax.Swing.Text.Document Document
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.Document>("getDocument", "()Ljavax/swing/text/Document;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.html#getLength()"/> 
        /// </summary>
        public int Length
        {
            get { return IExecuteWithSignature<int>("getLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.html#getOffset()"/> 
        /// </summary>
        public int Offset
        {
            get { return IExecuteWithSignature<int>("getOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.html#getType()"/> 
        /// </summary>
        public Javax.Swing.Event.DocumentEvent.EventType Type
        {
            get { return IExecuteWithSignature<Javax.Swing.Event.DocumentEvent.EventType>("getType", "()Ljavax/swing/event/DocumentEvent$EventType;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.html#getChange(javax.swing.text.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        /// <returns><see cref="Javax.Swing.Event.DocumentEvent.ElementChange"/></returns>
        public Javax.Swing.Event.DocumentEvent.ElementChange GetChange(Javax.Swing.Text.Element arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Event.DocumentEvent.ElementChange>("getChange", "(Ljavax/swing/text/Element;)Ljavax/swing/event/DocumentEvent$ElementChange;", arg0);
        }

        #endregion

        #region Nested classes
        #region ElementChange
        public partial class ElementChange
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.ElementChange.html#getChildrenAdded()"/> 
            /// </summary>
            public Javax.Swing.Text.Element[] ChildrenAdded
            {
                get { return IExecuteWithSignatureArray<Javax.Swing.Text.Element>("getChildrenAdded", "()[Ljavax/swing/text/Element;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.ElementChange.html#getChildrenRemoved()"/> 
            /// </summary>
            public Javax.Swing.Text.Element[] ChildrenRemoved
            {
                get { return IExecuteWithSignatureArray<Javax.Swing.Text.Element>("getChildrenRemoved", "()[Ljavax/swing/text/Element;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.ElementChange.html#getElement()"/> 
            /// </summary>
            public Javax.Swing.Text.Element Element
            {
                get { return IExecuteWithSignature<Javax.Swing.Text.Element>("getElement", "()Ljavax/swing/text/Element;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.ElementChange.html#getIndex()"/> 
            /// </summary>
            public int Index
            {
                get { return IExecuteWithSignature<int>("getIndex", "()I"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region EventType
        public partial class EventType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.EventType.html#CHANGE"/>
            /// </summary>
            public static Javax.Swing.Event.DocumentEvent.EventType CHANGE { get { if (!_CHANGEReady) { _CHANGEContent = SGetField<Javax.Swing.Event.DocumentEvent.EventType>(LocalBridgeClazz, "CHANGE"); _CHANGEReady = true; } return _CHANGEContent; } }
            private static Javax.Swing.Event.DocumentEvent.EventType _CHANGEContent = default;
            private static bool _CHANGEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.EventType.html#INSERT"/>
            /// </summary>
            public static Javax.Swing.Event.DocumentEvent.EventType INSERT { get { if (!_INSERTReady) { _INSERTContent = SGetField<Javax.Swing.Event.DocumentEvent.EventType>(LocalBridgeClazz, "INSERT"); _INSERTReady = true; } return _INSERTContent; } }
            private static Javax.Swing.Event.DocumentEvent.EventType _INSERTContent = default;
            private static bool _INSERTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentEvent.EventType.html#REMOVE"/>
            /// </summary>
            public static Javax.Swing.Event.DocumentEvent.EventType REMOVE { get { if (!_REMOVEReady) { _REMOVEContent = SGetField<Javax.Swing.Event.DocumentEvent.EventType>(LocalBridgeClazz, "REMOVE"); _REMOVEReady = true; } return _REMOVEContent; } }
            private static Javax.Swing.Event.DocumentEvent.EventType _REMOVEContent = default;
            private static bool _REMOVEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}