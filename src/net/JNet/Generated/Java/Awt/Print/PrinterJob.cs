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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Print
{
    #region PrinterJob declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html"/>
    /// </summary>
    public partial class PrinterJob : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PrinterJob>
    {
        const string _bridgeClassName = "java.awt.print.PrinterJob";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("PrinterJob class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PrinterJob() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("PrinterJob class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PrinterJob(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region PrinterJob implementation
    public partial class PrinterJob
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#getPrinterJob()"/> 
        /// </summary>
        public static Java.Awt.Print.PrinterJob GetPrinterJob
        {
            get { return SExecuteWithSignature<Java.Awt.Print.PrinterJob>(LocalBridgeClazz, "getPrinterJob", "()Ljava/awt/print/PrinterJob;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#lookupPrintServices()"/>
        /// </summary>
        /// <returns><see cref="Javax.Print.PrintService"/></returns>
        public static Javax.Print.PrintService[] LookupPrintServices()
        {
            return SExecuteWithSignatureArray<Javax.Print.PrintService>(LocalBridgeClazz, "lookupPrintServices", "()[Ljavax/print/PrintService;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#lookupStreamPrintServices(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Print.StreamPrintServiceFactory"/></returns>
        public static Javax.Print.StreamPrintServiceFactory[] LookupStreamPrintServices(Java.Lang.String arg0)
        {
            return SExecuteWithSignatureArray<Javax.Print.StreamPrintServiceFactory>(LocalBridgeClazz, "lookupStreamPrintServices", "(Ljava/lang/String;)[Ljavax/print/StreamPrintServiceFactory;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#getCopies()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#setCopies(int)"/>
        /// </summary>
        public int Copies
        {
            get { return IExecuteWithSignature<int>("getCopies", "()I"); } set { IExecuteWithSignature("setCopies", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#getJobName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#setJobName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String JobName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getJobName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setJobName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#getPrintService()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#setPrintService(javax.print.PrintService)"/>
        /// </summary>
        public Javax.Print.PrintService PrintService
        {
            get { return IExecuteWithSignature<Javax.Print.PrintService>("getPrintService", "()Ljavax/print/PrintService;"); } set { IExecuteWithSignature("setPrintService", "(Ljavax/print/PrintService;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#getUserName()"/> 
        /// </summary>
        public Java.Lang.String UserName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getUserName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#isCancelled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCancelled()
        {
            return IExecuteWithSignature<bool>("isCancelled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#printDialog()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public bool PrintDialog()
        {
            return IExecuteWithSignature<bool>("printDialog", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#defaultPage(java.awt.print.PageFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Print.PageFormat"/></param>
        /// <returns><see cref="Java.Awt.Print.PageFormat"/></returns>
        public Java.Awt.Print.PageFormat DefaultPage(Java.Awt.Print.PageFormat arg0)
        {
            return IExecuteWithSignature<Java.Awt.Print.PageFormat>("defaultPage", "(Ljava/awt/print/PageFormat;)Ljava/awt/print/PageFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#pageDialog(java.awt.print.PageFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Print.PageFormat"/></param>
        /// <returns><see cref="Java.Awt.Print.PageFormat"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Java.Awt.Print.PageFormat PageDialog(Java.Awt.Print.PageFormat arg0)
        {
            return IExecuteWithSignature<Java.Awt.Print.PageFormat>("pageDialog", "(Ljava/awt/print/PageFormat;)Ljava/awt/print/PageFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#validatePage(java.awt.print.PageFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Print.PageFormat"/></param>
        /// <returns><see cref="Java.Awt.Print.PageFormat"/></returns>
        public Java.Awt.Print.PageFormat ValidatePage(Java.Awt.Print.PageFormat arg0)
        {
            return IExecuteWithSignature<Java.Awt.Print.PageFormat>("validatePage", "(Ljava/awt/print/PageFormat;)Ljava/awt/print/PageFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#print()"/>
        /// </summary>
        /// <exception cref="Java.Awt.Print.PrinterException"/>
        public void Print()
        {
            IExecuteWithSignature("print", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#setPageable(java.awt.print.Pageable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Print.Pageable"/></param>
        /// <exception cref="Java.Lang.NullPointerException"/>
        public void SetPageable(Java.Awt.Print.Pageable arg0)
        {
            IExecuteWithSignature("setPageable", "(Ljava/awt/print/Pageable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#setPrintable(java.awt.print.Printable,java.awt.print.PageFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Print.Printable"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Print.PageFormat"/></param>
        public void SetPrintable(Java.Awt.Print.Printable arg0, Java.Awt.Print.PageFormat arg1)
        {
            IExecuteWithSignature("setPrintable", "(Ljava/awt/print/Printable;Ljava/awt/print/PageFormat;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#setPrintable(java.awt.print.Printable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Print.Printable"/></param>
        public void SetPrintable(Java.Awt.Print.Printable arg0)
        {
            IExecuteWithSignature("setPrintable", "(Ljava/awt/print/Printable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#printDialog(javax.print.attribute.PrintRequestAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public bool PrintDialog(Javax.Print.Attribute.PrintRequestAttributeSet arg0)
        {
            return IExecuteWithSignature<bool>("printDialog", "(Ljavax/print/attribute/PrintRequestAttributeSet;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#defaultPage()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.Print.PageFormat"/></returns>
        public Java.Awt.Print.PageFormat DefaultPage()
        {
            return IExecuteWithSignature<Java.Awt.Print.PageFormat>("defaultPage", "()Ljava/awt/print/PageFormat;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#getPageFormat(javax.print.attribute.PrintRequestAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Print.PageFormat"/></returns>
        public Java.Awt.Print.PageFormat GetPageFormat(Javax.Print.Attribute.PrintRequestAttributeSet arg0)
        {
            return IExecuteWithSignature<Java.Awt.Print.PageFormat>("getPageFormat", "(Ljavax/print/attribute/PrintRequestAttributeSet;)Ljava/awt/print/PageFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#pageDialog(javax.print.attribute.PrintRequestAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Print.PageFormat"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Java.Awt.Print.PageFormat PageDialog(Javax.Print.Attribute.PrintRequestAttributeSet arg0)
        {
            return IExecuteWithSignature<Java.Awt.Print.PageFormat>("pageDialog", "(Ljavax/print/attribute/PrintRequestAttributeSet;)Ljava/awt/print/PageFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#print(javax.print.attribute.PrintRequestAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></param>
        /// <exception cref="Java.Awt.Print.PrinterException"/>
        public void Print(Javax.Print.Attribute.PrintRequestAttributeSet arg0)
        {
            IExecuteWithSignature("print", "(Ljavax/print/attribute/PrintRequestAttributeSet;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}