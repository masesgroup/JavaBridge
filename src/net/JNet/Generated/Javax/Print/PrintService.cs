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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print
{
    #region IPrintService
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPrintService
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getAttributes()"/> 
        /// </summary>
        Javax.Print.Attribute.PrintServiceAttributeSet Attributes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getName()"/> 
        /// </summary>
        Java.Lang.String Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getServiceUIFactory()"/> 
        /// </summary>
        Javax.Print.ServiceUIFactory ServiceUIFactory { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getSupportedAttributeCategories()"/> 
        /// </summary>
        Java.Lang.Class[] SupportedAttributeCategories { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getSupportedDocFlavors()"/> 
        /// </summary>
        Javax.Print.DocFlavor[] SupportedDocFlavors { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getAttribute(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Javax.Print.Attribute.IPrintServiceAttribute"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        T GetAttribute<T>(Java.Lang.Class arg0) where T: Javax.Print.Attribute.IPrintServiceAttribute, new();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#isAttributeCategorySupported(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsAttributeCategorySupported(Java.Lang.Class arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#isAttributeValueSupported(javax.print.attribute.Attribute,javax.print.DocFlavor,javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.Attribute"/></param>
        /// <param name="arg1"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg2"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsAttributeValueSupported(Javax.Print.Attribute.Attribute arg0, Javax.Print.DocFlavor arg1, Javax.Print.Attribute.AttributeSet arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#isDocFlavorSupported(javax.print.DocFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.DocFlavor"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsDocFlavorSupported(Javax.Print.DocFlavor arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getDefaultAttributeValue(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="object"/></returns>
        object GetDefaultAttributeValue(Java.Lang.Class arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getSupportedAttributeValues(java.lang.Class,javax.print.DocFlavor,javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg2"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="object"/></returns>
        object GetSupportedAttributeValues(Java.Lang.Class arg0, Javax.Print.DocFlavor arg1, Javax.Print.Attribute.AttributeSet arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getUnsupportedAttributes(javax.print.DocFlavor,javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="Javax.Print.Attribute.AttributeSet"/></returns>
        Javax.Print.Attribute.AttributeSet GetUnsupportedAttributes(Javax.Print.DocFlavor arg0, Javax.Print.Attribute.AttributeSet arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#createPrintJob()"/>
        /// </summary>
        /// <returns><see cref="Javax.Print.DocPrintJob"/></returns>
        Javax.Print.DocPrintJob CreatePrintJob();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#addPrintServiceAttributeListener(javax.print.event.PrintServiceAttributeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintServiceAttributeListener"/></param>
        void AddPrintServiceAttributeListener(Javax.Print.Event.PrintServiceAttributeListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#removePrintServiceAttributeListener(javax.print.event.PrintServiceAttributeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintServiceAttributeListener"/></param>
        void RemovePrintServiceAttributeListener(Javax.Print.Event.PrintServiceAttributeListener arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PrintService
    public partial class PrintService : Javax.Print.IPrintService
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getAttributes()"/> 
        /// </summary>
        public Javax.Print.Attribute.PrintServiceAttributeSet Attributes
        {
            get { return IExecuteWithSignature<Javax.Print.Attribute.PrintServiceAttributeSet>("getAttributes", "()Ljavax/print/attribute/PrintServiceAttributeSet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getServiceUIFactory()"/> 
        /// </summary>
        public Javax.Print.ServiceUIFactory ServiceUIFactory
        {
            get { return IExecuteWithSignature<Javax.Print.ServiceUIFactory>("getServiceUIFactory", "()Ljavax/print/ServiceUIFactory;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getSupportedAttributeCategories()"/> 
        /// </summary>
        public Java.Lang.Class[] SupportedAttributeCategories
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Class>("getSupportedAttributeCategories", "()[Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getSupportedDocFlavors()"/> 
        /// </summary>
        public Javax.Print.DocFlavor[] SupportedDocFlavors
        {
            get { return IExecuteWithSignatureArray<Javax.Print.DocFlavor>("getSupportedDocFlavors", "()[Ljavax/print/DocFlavor;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getAttribute(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Javax.Print.Attribute.IPrintServiceAttribute"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetAttribute<T>(Java.Lang.Class arg0) where T: Javax.Print.Attribute.IPrintServiceAttribute, new()
        {
            return IExecute<T>("getAttribute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#isAttributeCategorySupported(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAttributeCategorySupported(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<bool>("isAttributeCategorySupported", "(Ljava/lang/Class;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#isAttributeValueSupported(javax.print.attribute.Attribute,javax.print.DocFlavor,javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.Attribute"/></param>
        /// <param name="arg1"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg2"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAttributeValueSupported(Javax.Print.Attribute.Attribute arg0, Javax.Print.DocFlavor arg1, Javax.Print.Attribute.AttributeSet arg2)
        {
            return IExecute<bool>("isAttributeValueSupported", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#isDocFlavorSupported(javax.print.DocFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.DocFlavor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDocFlavorSupported(Javax.Print.DocFlavor arg0)
        {
            return IExecuteWithSignature<bool>("isDocFlavorSupported", "(Ljavax/print/DocFlavor;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getDefaultAttributeValue(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetDefaultAttributeValue(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature("getDefaultAttributeValue", "(Ljava/lang/Class;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getSupportedAttributeValues(java.lang.Class,javax.print.DocFlavor,javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg2"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetSupportedAttributeValues(Java.Lang.Class arg0, Javax.Print.DocFlavor arg1, Javax.Print.Attribute.AttributeSet arg2)
        {
            return IExecute("getSupportedAttributeValues", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getUnsupportedAttributes(javax.print.DocFlavor,javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="Javax.Print.Attribute.AttributeSet"/></returns>
        public Javax.Print.Attribute.AttributeSet GetUnsupportedAttributes(Javax.Print.DocFlavor arg0, Javax.Print.Attribute.AttributeSet arg1)
        {
            return IExecute<Javax.Print.Attribute.AttributeSet>("getUnsupportedAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#createPrintJob()"/>
        /// </summary>
        /// <returns><see cref="Javax.Print.DocPrintJob"/></returns>
        public Javax.Print.DocPrintJob CreatePrintJob()
        {
            return IExecuteWithSignature<Javax.Print.DocPrintJob>("createPrintJob", "()Ljavax/print/DocPrintJob;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#addPrintServiceAttributeListener(javax.print.event.PrintServiceAttributeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintServiceAttributeListener"/></param>
        public void AddPrintServiceAttributeListener(Javax.Print.Event.PrintServiceAttributeListener arg0)
        {
            IExecuteWithSignature("addPrintServiceAttributeListener", "(Ljavax/print/event/PrintServiceAttributeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#removePrintServiceAttributeListener(javax.print.event.PrintServiceAttributeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintServiceAttributeListener"/></param>
        public void RemovePrintServiceAttributeListener(Javax.Print.Event.PrintServiceAttributeListener arg0)
        {
            IExecuteWithSignature("removePrintServiceAttributeListener", "(Ljavax/print/event/PrintServiceAttributeListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}