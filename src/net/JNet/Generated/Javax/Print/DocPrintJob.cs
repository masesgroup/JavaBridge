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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print
{
    #region IDocPrintJob
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDocPrintJob
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#getAttributes()"/> 
        /// </summary>
        Javax.Print.Attribute.PrintJobAttributeSet Attributes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#getPrintService()"/> 
        /// </summary>
        Javax.Print.PrintService PrintService { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#addPrintJobAttributeListener(javax.print.event.PrintJobAttributeListener,javax.print.attribute.PrintJobAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobAttributeListener"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.PrintJobAttributeSet"/></param>
        void AddPrintJobAttributeListener(Javax.Print.Event.PrintJobAttributeListener arg0, Javax.Print.Attribute.PrintJobAttributeSet arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#addPrintJobListener(javax.print.event.PrintJobListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobListener"/></param>
        void AddPrintJobListener(Javax.Print.Event.PrintJobListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#print(javax.print.Doc,javax.print.attribute.PrintRequestAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Doc"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></param>
        /// <exception cref="Javax.Print.PrintException"/>
        void Print(Javax.Print.Doc arg0, Javax.Print.Attribute.PrintRequestAttributeSet arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#removePrintJobAttributeListener(javax.print.event.PrintJobAttributeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobAttributeListener"/></param>
        void RemovePrintJobAttributeListener(Javax.Print.Event.PrintJobAttributeListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#removePrintJobListener(javax.print.event.PrintJobListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobListener"/></param>
        void RemovePrintJobListener(Javax.Print.Event.PrintJobListener arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DocPrintJob
    public partial class DocPrintJob : Javax.Print.IDocPrintJob
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#getAttributes()"/> 
        /// </summary>
        public Javax.Print.Attribute.PrintJobAttributeSet Attributes
        {
            get { return IExecuteWithSignature<Javax.Print.Attribute.PrintJobAttributeSet>("getAttributes", "()Ljavax/print/attribute/PrintJobAttributeSet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#getPrintService()"/> 
        /// </summary>
        public Javax.Print.PrintService PrintService
        {
            get { return IExecuteWithSignature<Javax.Print.PrintService>("getPrintService", "()Ljavax/print/PrintService;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#addPrintJobAttributeListener(javax.print.event.PrintJobAttributeListener,javax.print.attribute.PrintJobAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobAttributeListener"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.PrintJobAttributeSet"/></param>
        public void AddPrintJobAttributeListener(Javax.Print.Event.PrintJobAttributeListener arg0, Javax.Print.Attribute.PrintJobAttributeSet arg1)
        {
            IExecute("addPrintJobAttributeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#addPrintJobListener(javax.print.event.PrintJobListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobListener"/></param>
        public void AddPrintJobListener(Javax.Print.Event.PrintJobListener arg0)
        {
            IExecuteWithSignature("addPrintJobListener", "(Ljavax/print/event/PrintJobListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#print(javax.print.Doc,javax.print.attribute.PrintRequestAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Doc"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></param>
        /// <exception cref="Javax.Print.PrintException"/>
        public void Print(Javax.Print.Doc arg0, Javax.Print.Attribute.PrintRequestAttributeSet arg1)
        {
            IExecute("print", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#removePrintJobAttributeListener(javax.print.event.PrintJobAttributeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobAttributeListener"/></param>
        public void RemovePrintJobAttributeListener(Javax.Print.Event.PrintJobAttributeListener arg0)
        {
            IExecuteWithSignature("removePrintJobAttributeListener", "(Ljavax/print/event/PrintJobAttributeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#removePrintJobListener(javax.print.event.PrintJobListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobListener"/></param>
        public void RemovePrintJobListener(Javax.Print.Event.PrintJobListener arg0)
        {
            IExecuteWithSignature("removePrintJobListener", "(Ljavax/print/event/PrintJobListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}