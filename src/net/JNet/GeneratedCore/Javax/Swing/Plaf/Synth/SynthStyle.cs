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

namespace Javax.Swing.Plaf.Synth
{
    #region SynthStyle
    public partial class SynthStyle
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthStyle.html#getBoolean(javax.swing.plaf.synth.SynthContext,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetBoolean(Javax.Swing.Plaf.Synth.SynthContext arg0, object arg1, bool arg2)
        {
            return IExecute<bool>("getBoolean", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthStyle.html#isOpaque(javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpaque(Javax.Swing.Plaf.Synth.SynthContext arg0)
        {
            return IExecuteWithSignature<bool>("isOpaque", "(Ljavax/swing/plaf/synth/SynthContext;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthStyle.html#getInt(javax.swing.plaf.synth.SynthContext,java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetInt(Javax.Swing.Plaf.Synth.SynthContext arg0, object arg1, int arg2)
        {
            return IExecute<int>("getInt", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthStyle.html#getColor(javax.swing.plaf.synth.SynthContext,javax.swing.plaf.synth.ColorType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Plaf.Synth.ColorType"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetColor(Javax.Swing.Plaf.Synth.SynthContext arg0, Javax.Swing.Plaf.Synth.ColorType arg1)
        {
            return IExecute<Java.Awt.Color>("getColor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthStyle.html#getFont(javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public Java.Awt.Font GetFont(Javax.Swing.Plaf.Synth.SynthContext arg0)
        {
            return IExecuteWithSignature<Java.Awt.Font>("getFont", "(Ljavax/swing/plaf/synth/SynthContext;)Ljava/awt/Font;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthStyle.html#getInsets(javax.swing.plaf.synth.SynthContext,java.awt.Insets)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Insets"/></param>
        /// <returns><see cref="Java.Awt.Insets"/></returns>
        public Java.Awt.Insets GetInsets(Javax.Swing.Plaf.Synth.SynthContext arg0, Java.Awt.Insets arg1)
        {
            return IExecute<Java.Awt.Insets>("getInsets", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthStyle.html#get(javax.swing.plaf.synth.SynthContext,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(Javax.Swing.Plaf.Synth.SynthContext arg0, object arg1)
        {
            return IExecute("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthStyle.html#getString(javax.swing.plaf.synth.SynthContext,java.lang.Object,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetString(Javax.Swing.Plaf.Synth.SynthContext arg0, object arg1, Java.Lang.String arg2)
        {
            return IExecute<Java.Lang.String>("getString", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthStyle.html#getIcon(javax.swing.plaf.synth.SynthContext,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Javax.Swing.Icon"/></returns>
        public Javax.Swing.Icon GetIcon(Javax.Swing.Plaf.Synth.SynthContext arg0, object arg1)
        {
            return IExecute<Javax.Swing.Icon>("getIcon", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthStyle.html#getGraphicsUtils(javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <returns><see cref="Javax.Swing.Plaf.Synth.SynthGraphicsUtils"/></returns>
        public Javax.Swing.Plaf.Synth.SynthGraphicsUtils GetGraphicsUtils(Javax.Swing.Plaf.Synth.SynthContext arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Plaf.Synth.SynthGraphicsUtils>("getGraphicsUtils", "(Ljavax/swing/plaf/synth/SynthContext;)Ljavax/swing/plaf/synth/SynthGraphicsUtils;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthStyle.html#getPainter(javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <returns><see cref="Javax.Swing.Plaf.Synth.SynthPainter"/></returns>
        public Javax.Swing.Plaf.Synth.SynthPainter GetPainter(Javax.Swing.Plaf.Synth.SynthContext arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Plaf.Synth.SynthPainter>("getPainter", "(Ljavax/swing/plaf/synth/SynthContext;)Ljavax/swing/plaf/synth/SynthPainter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthStyle.html#installDefaults(javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        public void InstallDefaults(Javax.Swing.Plaf.Synth.SynthContext arg0)
        {
            IExecuteWithSignature("installDefaults", "(Ljavax/swing/plaf/synth/SynthContext;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthStyle.html#uninstallDefaults(javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        public void UninstallDefaults(Javax.Swing.Plaf.Synth.SynthContext arg0)
        {
            IExecuteWithSignature("uninstallDefaults", "(Ljavax/swing/plaf/synth/SynthContext;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}