/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Spi
{
    #region NamingManager
    public partial class NamingManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/NamingManager.html#CPE"/>
        /// </summary>
        public static string CPE => Clazz.GetField<string>("CPE");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/NamingManager.html#hasInitialContextFactoryBuilder()"/> 
        /// </summary>
        public static bool HasInitialContextFactoryBuilder
        {
            get { return SExecute<bool>(LocalClazz, "hasInitialContextFactoryBuilder"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/NamingManager.html#getObjectInstance(java.lang.Object,javax.naming.Name,javax.naming.Context,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Context"/></param>
        /// <param name="arg3"><see cref="Java.Util.Hashtable"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        public static object GetObjectInstance<Arg3Extendsobject>(object arg0, Javax.Naming.Name arg1, Javax.Naming.Context arg2, Java.Util.Hashtable<Arg3Extendsobject, Arg3Extendsobject> arg3)
        {
            return SExecute(LocalClazz, "getObjectInstance", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/NamingManager.html#getStateToBind(java.lang.Object,javax.naming.Name,javax.naming.Context,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Context"/></param>
        /// <param name="arg3"><see cref="Java.Util.Hashtable"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public static object GetStateToBind<Arg3Extendsobject>(object arg0, Javax.Naming.Name arg1, Javax.Naming.Context arg2, Java.Util.Hashtable<Arg3Extendsobject, Arg3Extendsobject> arg3)
        {
            return SExecute(LocalClazz, "getStateToBind", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/NamingManager.html#getContinuationContext(javax.naming.CannotProceedException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.CannotProceedException"/></param>
        /// <returns><see cref="Javax.Naming.Context"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public static Javax.Naming.Context GetContinuationContext(Javax.Naming.CannotProceedException arg0)
        {
            return SExecute<Javax.Naming.Context>(LocalClazz, "getContinuationContext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/NamingManager.html#getInitialContext(java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Hashtable"/></param>
        /// <returns><see cref="Javax.Naming.Context"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public static Javax.Naming.Context GetInitialContext<Arg0Extendsobject>(Java.Util.Hashtable<Arg0Extendsobject, Arg0Extendsobject> arg0)
        {
            return SExecute<Javax.Naming.Context>(LocalClazz, "getInitialContext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/NamingManager.html#getURLContext(java.lang.String,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Hashtable"/></param>
        /// <returns><see cref="Javax.Naming.Context"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public static Javax.Naming.Context GetURLContext<Arg1Extendsobject>(string arg0, Java.Util.Hashtable<Arg1Extendsobject, Arg1Extendsobject> arg1)
        {
            return SExecute<Javax.Naming.Context>(LocalClazz, "getURLContext", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/NamingManager.html#setInitialContextFactoryBuilder(javax.naming.spi.InitialContextFactoryBuilder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Spi.InitialContextFactoryBuilder"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public static void SetInitialContextFactoryBuilder(Javax.Naming.Spi.InitialContextFactoryBuilder arg0)
        {
            SExecute(LocalClazz, "setInitialContextFactoryBuilder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/NamingManager.html#setObjectFactoryBuilder(javax.naming.spi.ObjectFactoryBuilder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Spi.ObjectFactoryBuilder"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public static void SetObjectFactoryBuilder(Javax.Naming.Spi.ObjectFactoryBuilder arg0)
        {
            SExecute(LocalClazz, "setObjectFactoryBuilder", arg0);
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