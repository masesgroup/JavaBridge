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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region BorderFactory
    public partial class BorderFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createBevelBorder(int,java.awt.Color,java.awt.Color,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Color"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateBevelBorder(int arg0, Java.Awt.Color arg1, Java.Awt.Color arg2, Java.Awt.Color arg3, Java.Awt.Color arg4)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createBevelBorder", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createBevelBorder(int,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateBevelBorder(int arg0, Java.Awt.Color arg1, Java.Awt.Color arg2)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createBevelBorder", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createBevelBorder(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateBevelBorder(int arg0)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createBevelBorder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createDashedBorder(java.awt.Paint,float,float,float,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Paint"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateDashedBorder(Java.Awt.Paint arg0, float arg1, float arg2, float arg3, bool arg4)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createDashedBorder", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createDashedBorder(java.awt.Paint,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Paint"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateDashedBorder(Java.Awt.Paint arg0, float arg1, float arg2)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createDashedBorder", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createDashedBorder(java.awt.Paint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Paint"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateDashedBorder(Java.Awt.Paint arg0)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createDashedBorder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createEmptyBorder()"/>
        /// </summary>

        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateEmptyBorder()
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createEmptyBorder");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createEmptyBorder(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateEmptyBorder(int arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createEmptyBorder", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createEtchedBorder()"/>
        /// </summary>

        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateEtchedBorder()
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createEtchedBorder");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createEtchedBorder(int,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateEtchedBorder(int arg0, Java.Awt.Color arg1, Java.Awt.Color arg2)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createEtchedBorder", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createEtchedBorder(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateEtchedBorder(int arg0)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createEtchedBorder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createEtchedBorder(java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateEtchedBorder(Java.Awt.Color arg0, Java.Awt.Color arg1)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createEtchedBorder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createLineBorder(java.awt.Color,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateLineBorder(Java.Awt.Color arg0, int arg1, bool arg2)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createLineBorder", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createLineBorder(java.awt.Color,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateLineBorder(Java.Awt.Color arg0, int arg1)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createLineBorder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createLineBorder(java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateLineBorder(Java.Awt.Color arg0)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createLineBorder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createLoweredBevelBorder()"/>
        /// </summary>

        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateLoweredBevelBorder()
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createLoweredBevelBorder");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createLoweredSoftBevelBorder()"/>
        /// </summary>

        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateLoweredSoftBevelBorder()
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createLoweredSoftBevelBorder");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createRaisedBevelBorder()"/>
        /// </summary>

        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateRaisedBevelBorder()
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createRaisedBevelBorder");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createRaisedSoftBevelBorder()"/>
        /// </summary>

        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateRaisedSoftBevelBorder()
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createRaisedSoftBevelBorder");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createSoftBevelBorder(int,java.awt.Color,java.awt.Color,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Color"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateSoftBevelBorder(int arg0, Java.Awt.Color arg1, Java.Awt.Color arg2, Java.Awt.Color arg3, Java.Awt.Color arg4)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createSoftBevelBorder", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createSoftBevelBorder(int,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateSoftBevelBorder(int arg0, Java.Awt.Color arg1, Java.Awt.Color arg2)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createSoftBevelBorder", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createSoftBevelBorder(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateSoftBevelBorder(int arg0)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createSoftBevelBorder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createStrokeBorder(java.awt.BasicStroke,java.awt.Paint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.BasicStroke"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Paint"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateStrokeBorder(Java.Awt.BasicStroke arg0, Java.Awt.Paint arg1)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createStrokeBorder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createStrokeBorder(java.awt.BasicStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.BasicStroke"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border CreateStrokeBorder(Java.Awt.BasicStroke arg0)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "createStrokeBorder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createCompoundBorder()"/>
        /// </summary>

        /// <returns><see cref="Javax.Swing.Border.CompoundBorder"/></returns>
        public static Javax.Swing.Border.CompoundBorder CreateCompoundBorder()
        {
            return SExecute<Javax.Swing.Border.CompoundBorder>(LocalBridgeClazz, "createCompoundBorder");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createCompoundBorder(javax.swing.border.Border,javax.swing.border.Border)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Border.Border"/></param>
        /// <returns><see cref="Javax.Swing.Border.CompoundBorder"/></returns>
        public static Javax.Swing.Border.CompoundBorder CreateCompoundBorder(Javax.Swing.Border.Border arg0, Javax.Swing.Border.Border arg1)
        {
            return SExecute<Javax.Swing.Border.CompoundBorder>(LocalBridgeClazz, "createCompoundBorder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createMatteBorder(int,int,int,int,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Color"/></param>
        /// <returns><see cref="Javax.Swing.Border.MatteBorder"/></returns>
        public static Javax.Swing.Border.MatteBorder CreateMatteBorder(int arg0, int arg1, int arg2, int arg3, Java.Awt.Color arg4)
        {
            return SExecute<Javax.Swing.Border.MatteBorder>(LocalBridgeClazz, "createMatteBorder", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createMatteBorder(int,int,int,int,javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Icon"/></param>
        /// <returns><see cref="Javax.Swing.Border.MatteBorder"/></returns>
        public static Javax.Swing.Border.MatteBorder CreateMatteBorder(int arg0, int arg1, int arg2, int arg3, Javax.Swing.Icon arg4)
        {
            return SExecute<Javax.Swing.Border.MatteBorder>(LocalBridgeClazz, "createMatteBorder", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createTitledBorder(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.Border.TitledBorder"/></returns>
        public static Javax.Swing.Border.TitledBorder CreateTitledBorder(string arg0)
        {
            return SExecute<Javax.Swing.Border.TitledBorder>(LocalBridgeClazz, "createTitledBorder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createTitledBorder(javax.swing.border.Border,java.lang.String,int,int,java.awt.Font,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Font"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Color"/></param>
        /// <returns><see cref="Javax.Swing.Border.TitledBorder"/></returns>
        public static Javax.Swing.Border.TitledBorder CreateTitledBorder(Javax.Swing.Border.Border arg0, string arg1, int arg2, int arg3, Java.Awt.Font arg4, Java.Awt.Color arg5)
        {
            return SExecute<Javax.Swing.Border.TitledBorder>(LocalBridgeClazz, "createTitledBorder", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createTitledBorder(javax.swing.border.Border,java.lang.String,int,int,java.awt.Font)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Font"/></param>
        /// <returns><see cref="Javax.Swing.Border.TitledBorder"/></returns>
        public static Javax.Swing.Border.TitledBorder CreateTitledBorder(Javax.Swing.Border.Border arg0, string arg1, int arg2, int arg3, Java.Awt.Font arg4)
        {
            return SExecute<Javax.Swing.Border.TitledBorder>(LocalBridgeClazz, "createTitledBorder", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createTitledBorder(javax.swing.border.Border,java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Border.TitledBorder"/></returns>
        public static Javax.Swing.Border.TitledBorder CreateTitledBorder(Javax.Swing.Border.Border arg0, string arg1, int arg2, int arg3)
        {
            return SExecute<Javax.Swing.Border.TitledBorder>(LocalBridgeClazz, "createTitledBorder", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createTitledBorder(javax.swing.border.Border,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.Border.TitledBorder"/></returns>
        public static Javax.Swing.Border.TitledBorder CreateTitledBorder(Javax.Swing.Border.Border arg0, string arg1)
        {
            return SExecute<Javax.Swing.Border.TitledBorder>(LocalBridgeClazz, "createTitledBorder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BorderFactory.html#createTitledBorder(javax.swing.border.Border)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        /// <returns><see cref="Javax.Swing.Border.TitledBorder"/></returns>
        public static Javax.Swing.Border.TitledBorder CreateTitledBorder(Javax.Swing.Border.Border arg0)
        {
            return SExecute<Javax.Swing.Border.TitledBorder>(LocalBridgeClazz, "createTitledBorder", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}