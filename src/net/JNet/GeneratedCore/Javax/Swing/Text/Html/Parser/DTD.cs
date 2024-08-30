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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text.Html.Parser
{
    #region DTD definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html"/>
    /// </summary>
    public partial class DTD : Javax.Swing.Text.Html.Parser.DTDConstants
    {
        const string _bridgeClassName = "javax.swing.text.html.parser.DTD";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DTD() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DTD(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
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

    #region DTD
    public partial class DTD
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#applet"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element applet { get { if (!_appletReady) { _appletContent = IGetField<Javax.Swing.Text.Html.Parser.Element>("applet"); _appletReady = true; } return _appletContent; } }
        private Javax.Swing.Text.Html.Parser.Element _appletContent = default;
        private bool _appletReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#base"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element baseField { get { if (!_baseFieldReady) { _baseFieldContent = IGetField<Javax.Swing.Text.Html.Parser.Element>("base"); _baseFieldReady = true; } return _baseFieldContent; } }
        private Javax.Swing.Text.Html.Parser.Element _baseFieldContent = default;
        private bool _baseFieldReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#body"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element body { get { if (!_bodyReady) { _bodyContent = IGetField<Javax.Swing.Text.Html.Parser.Element>("body"); _bodyReady = true; } return _bodyContent; } }
        private Javax.Swing.Text.Html.Parser.Element _bodyContent = default;
        private bool _bodyReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#head"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element head { get { if (!_headReady) { _headContent = IGetField<Javax.Swing.Text.Html.Parser.Element>("head"); _headReady = true; } return _headContent; } }
        private Javax.Swing.Text.Html.Parser.Element _headContent = default;
        private bool _headReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#html"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element html { get { if (!_htmlReady) { _htmlContent = IGetField<Javax.Swing.Text.Html.Parser.Element>("html"); _htmlReady = true; } return _htmlContent; } }
        private Javax.Swing.Text.Html.Parser.Element _htmlContent = default;
        private bool _htmlReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#isindex"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element isindex { get { if (!_isindexReady) { _isindexContent = IGetField<Javax.Swing.Text.Html.Parser.Element>("isindex"); _isindexReady = true; } return _isindexContent; } }
        private Javax.Swing.Text.Html.Parser.Element _isindexContent = default;
        private bool _isindexReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#meta"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element meta { get { if (!_metaReady) { _metaContent = IGetField<Javax.Swing.Text.Html.Parser.Element>("meta"); _metaReady = true; } return _metaContent; } }
        private Javax.Swing.Text.Html.Parser.Element _metaContent = default;
        private bool _metaReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#p"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element p { get { if (!_pReady) { _pContent = IGetField<Javax.Swing.Text.Html.Parser.Element>("p"); _pReady = true; } return _pContent; } }
        private Javax.Swing.Text.Html.Parser.Element _pContent = default;
        private bool _pReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#param"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element param { get { if (!_paramReady) { _paramContent = IGetField<Javax.Swing.Text.Html.Parser.Element>("param"); _paramReady = true; } return _paramContent; } }
        private Javax.Swing.Text.Html.Parser.Element _paramContent = default;
        private bool _paramReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#pcdata"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element pcdata { get { if (!_pcdataReady) { _pcdataContent = IGetField<Javax.Swing.Text.Html.Parser.Element>("pcdata"); _pcdataReady = true; } return _pcdataContent; } }
        private Javax.Swing.Text.Html.Parser.Element _pcdataContent = default;
        private bool _pcdataReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#title"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element title { get { if (!_titleReady) { _titleContent = IGetField<Javax.Swing.Text.Html.Parser.Element>("title"); _titleReady = true; } return _titleContent; } }
        private Javax.Swing.Text.Html.Parser.Element _titleContent = default;
        private bool _titleReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#name"/>
        /// </summary>
        public Java.Lang.String name { get { return IGetField<Java.Lang.String>("name"); } set { ISetField("name", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#entityHash"/>
        /// </summary>
        public Java.Util.Hashtable entityHash { get { return IGetField<Java.Util.Hashtable>("entityHash"); } set { ISetField("entityHash", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#elementHash"/>
        /// </summary>
        public Java.Util.Hashtable elementHash { get { return IGetField<Java.Util.Hashtable>("elementHash"); } set { ISetField("elementHash", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#elements"/>
        /// </summary>
        public Java.Util.Vector elements { get { return IGetField<Java.Util.Vector>("elements"); } set { ISetField("elements", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#FILE_VERSION"/>
        /// </summary>
        public static int FILE_VERSION { get { if (!_FILE_VERSIONReady) { _FILE_VERSIONContent = SGetField<int>(LocalBridgeClazz, "FILE_VERSION"); _FILE_VERSIONReady = true; } return _FILE_VERSIONContent; } }
        private static int _FILE_VERSIONContent = default;
        private static bool _FILE_VERSIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#getDTD(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.DTD"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Swing.Text.Html.Parser.DTD GetDTD(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Swing.Text.Html.Parser.DTD>(LocalBridgeClazz, "getDTD", "(Ljava/lang/String;)Ljavax/swing/text/html/parser/DTD;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#putDTDHash(java.lang.String,javax.swing.text.html.parser.DTD)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Html.Parser.DTD"/></param>
        public static void PutDTDHash(Java.Lang.String arg0, Javax.Swing.Text.Html.Parser.DTD arg1)
        {
            SExecute(LocalBridgeClazz, "putDTDHash", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#defineElement(java.lang.String,int,boolean,boolean,javax.swing.text.html.parser.ContentModel,java.util.BitSet,java.util.BitSet,javax.swing.text.html.parser.AttributeList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Text.Html.Parser.ContentModel"/></param>
        /// <param name="arg5"><see cref="Java.Util.BitSet"/></param>
        /// <param name="arg6"><see cref="Java.Util.BitSet"/></param>
        /// <param name="arg7"><see cref="Javax.Swing.Text.Html.Parser.AttributeList"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.Element"/></returns>
        public Javax.Swing.Text.Html.Parser.Element DefineElement(Java.Lang.String arg0, int arg1, bool arg2, bool arg3, Javax.Swing.Text.Html.Parser.ContentModel arg4, Java.Util.BitSet arg5, Java.Util.BitSet arg6, Javax.Swing.Text.Html.Parser.AttributeList arg7)
        {
            return IExecute<Javax.Swing.Text.Html.Parser.Element>("defineElement", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#getElement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.Element"/></returns>
        public Javax.Swing.Text.Html.Parser.Element GetElement(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Html.Parser.Element>("getElement", "(I)Ljavax/swing/text/html/parser/Element;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#getElement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.Element"/></returns>
        public Javax.Swing.Text.Html.Parser.Element GetElement(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Html.Parser.Element>("getElement", "(Ljava/lang/String;)Ljavax/swing/text/html/parser/Element;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#defEntity(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.Entity"/></returns>
        public Javax.Swing.Text.Html.Parser.Entity DefEntity(Java.Lang.String arg0, int arg1, int arg2)
        {
            return IExecute<Javax.Swing.Text.Html.Parser.Entity>("defEntity", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#defineEntity(java.lang.String,int,char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="char"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.Entity"/></returns>
        public Javax.Swing.Text.Html.Parser.Entity DefineEntity(Java.Lang.String arg0, int arg1, char[] arg2)
        {
            return IExecute<Javax.Swing.Text.Html.Parser.Entity>("defineEntity", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#getEntity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.Entity"/></returns>
        public Javax.Swing.Text.Html.Parser.Entity GetEntity(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Html.Parser.Entity>("getEntity", "(I)Ljavax/swing/text/html/parser/Entity;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#getEntity(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.Entity"/></returns>
        public Javax.Swing.Text.Html.Parser.Entity GetEntity(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Html.Parser.Entity>("getEntity", "(Ljava/lang/String;)Ljavax/swing/text/html/parser/Entity;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#defineAttributes(java.lang.String,javax.swing.text.html.parser.AttributeList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Html.Parser.AttributeList"/></param>
        public void DefineAttributes(Java.Lang.String arg0, Javax.Swing.Text.Html.Parser.AttributeList arg1)
        {
            IExecute("defineAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#read(java.io.DataInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.DataInputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Read(Java.Io.DataInputStream arg0)
        {
            IExecuteWithSignature("read", "(Ljava/io/DataInputStream;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}