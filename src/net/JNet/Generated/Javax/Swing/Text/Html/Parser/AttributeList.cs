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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text.Html.Parser
{
    #region AttributeList
    public partial class AttributeList
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#%3Cinit%3E(java.lang.String,int,int,java.lang.String,java.util.Vector,javax.swing.text.html.parser.AttributeList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Util.Vector"/></param>
        /// <param name="arg5"><see cref="Javax.Swing.Text.Html.Parser.AttributeList"/></param>
        public AttributeList(Java.Lang.String arg0, int arg1, int arg2, Java.Lang.String arg3, Java.Util.Vector<object> arg4, Javax.Swing.Text.Html.Parser.AttributeList arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public AttributeList(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.Html.Parser.AttributeList"/> to <see cref="Javax.Swing.Text.Html.Parser.DTDConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.Text.Html.Parser.DTDConstants(Javax.Swing.Text.Html.Parser.AttributeList t) => t.Cast<Javax.Swing.Text.Html.Parser.DTDConstants>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.Html.Parser.AttributeList"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Text.Html.Parser.AttributeList t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#modifier"/>
        /// </summary>
        public int modifier { get { return IGetField<int>("modifier"); } set { ISetField("modifier", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#type"/>
        /// </summary>
        public int type { get { return IGetField<int>("type"); } set { ISetField("type", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#name"/>
        /// </summary>
        public Java.Lang.String name { get { return IGetField<Java.Lang.String>("name"); } set { ISetField("name", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#value"/>
        /// </summary>
        public Java.Lang.String value { get { return IGetField<Java.Lang.String>("value"); } set { ISetField("value", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#values"/>
        /// </summary>
        public Java.Util.Vector values { get { return IGetField<Java.Util.Vector>("values"); } set { ISetField("values", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#next"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.AttributeList next { get { return IGetField<Javax.Swing.Text.Html.Parser.AttributeList>("next"); } set { ISetField("next", value); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#name2type(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Name2type(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "name2type", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#type2name(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Type2name(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "type2name", "(I)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#getModifier()"/> 
        /// </summary>
        public int Modifier
        {
            get { return IExecuteWithSignature<int>("getModifier", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#getNext()"/> 
        /// </summary>
        public Javax.Swing.Text.Html.Parser.AttributeList Next
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.Html.Parser.AttributeList>("getNext", "()Ljavax/swing/text/html/parser/AttributeList;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecuteWithSignature<int>("getType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#getValue()"/> 
        /// </summary>
        public Java.Lang.String Value
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getValue", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#getValues()"/> 
        /// </summary>
        public Java.Util.Enumeration<object> Values
        {
            get { return IExecuteWithSignature<Java.Util.Enumeration<object>>("getValues", "()Ljava/util/Enumeration;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}