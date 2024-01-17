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
    #region SizeRequirements
    public partial class SizeRequirements
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeRequirements.html#%3Cinit%3E(int,int,int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public SizeRequirements(int arg0, int arg1, int arg2, float arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeRequirements.html#alignment"/>
        /// </summary>
        public float alignment { get { return IGetField<float>("alignment"); } set { ISetField("alignment", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeRequirements.html#maximum"/>
        /// </summary>
        public int maximum { get { return IGetField<int>("maximum"); } set { ISetField("maximum", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeRequirements.html#minimum"/>
        /// </summary>
        public int minimum { get { return IGetField<int>("minimum"); } set { ISetField("minimum", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeRequirements.html#preferred"/>
        /// </summary>
        public int preferred { get { return IGetField<int>("preferred"); } set { ISetField("preferred", value); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeRequirements.html#adjustSizes(int,javax.swing.SizeRequirements[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.SizeRequirements"/></param>
        /// <returns><see cref="int"/></returns>
        public static int[] AdjustSizes(int arg0, Javax.Swing.SizeRequirements[] arg1)
        {
            return SExecuteArray<int>(LocalBridgeClazz, "adjustSizes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeRequirements.html#getAlignedSizeRequirements(javax.swing.SizeRequirements[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.SizeRequirements"/></param>
        /// <returns><see cref="Javax.Swing.SizeRequirements"/></returns>
        public static Javax.Swing.SizeRequirements GetAlignedSizeRequirements(Javax.Swing.SizeRequirements[] arg0)
        {
            return SExecute<Javax.Swing.SizeRequirements>(LocalBridgeClazz, "getAlignedSizeRequirements", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeRequirements.html#getTiledSizeRequirements(javax.swing.SizeRequirements[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.SizeRequirements"/></param>
        /// <returns><see cref="Javax.Swing.SizeRequirements"/></returns>
        public static Javax.Swing.SizeRequirements GetTiledSizeRequirements(Javax.Swing.SizeRequirements[] arg0)
        {
            return SExecute<Javax.Swing.SizeRequirements>(LocalBridgeClazz, "getTiledSizeRequirements", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeRequirements.html#calculateAlignedPositions(int,javax.swing.SizeRequirements,javax.swing.SizeRequirements[],int[],int[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.SizeRequirements"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.SizeRequirements"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        public static void CalculateAlignedPositions(int arg0, Javax.Swing.SizeRequirements arg1, Javax.Swing.SizeRequirements[] arg2, int[] arg3, int[] arg4, bool arg5)
        {
            SExecute(LocalBridgeClazz, "calculateAlignedPositions", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeRequirements.html#calculateAlignedPositions(int,javax.swing.SizeRequirements,javax.swing.SizeRequirements[],int[],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.SizeRequirements"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.SizeRequirements"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public static void CalculateAlignedPositions(int arg0, Javax.Swing.SizeRequirements arg1, Javax.Swing.SizeRequirements[] arg2, int[] arg3, int[] arg4)
        {
            SExecute(LocalBridgeClazz, "calculateAlignedPositions", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeRequirements.html#calculateTiledPositions(int,javax.swing.SizeRequirements,javax.swing.SizeRequirements[],int[],int[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.SizeRequirements"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.SizeRequirements"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        public static void CalculateTiledPositions(int arg0, Javax.Swing.SizeRequirements arg1, Javax.Swing.SizeRequirements[] arg2, int[] arg3, int[] arg4, bool arg5)
        {
            SExecute(LocalBridgeClazz, "calculateTiledPositions", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeRequirements.html#calculateTiledPositions(int,javax.swing.SizeRequirements,javax.swing.SizeRequirements[],int[],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.SizeRequirements"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.SizeRequirements"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public static void CalculateTiledPositions(int arg0, Javax.Swing.SizeRequirements arg1, Javax.Swing.SizeRequirements[] arg2, int[] arg3, int[] arg4)
        {
            SExecute(LocalBridgeClazz, "calculateTiledPositions", arg0, arg1, arg2, arg3, arg4);
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