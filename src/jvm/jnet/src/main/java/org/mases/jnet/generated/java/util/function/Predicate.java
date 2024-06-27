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
*/

package org.mases.jnet.generated.java.util.function;

public final class Predicate extends org.mases.jcobridge.JCListener implements java.util.function.Predicate {
    public Predicate(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public boolean test(java.lang.Object arg0) {
        raiseEvent("test", arg0); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public java.util.function.Predicate and(java.util.function.Predicate arg0) {
        raiseEvent("and", arg0); Object retVal = getReturnData(); return (java.util.function.Predicate)retVal;
    }
    //@Override
    public java.util.function.Predicate andDefault(java.util.function.Predicate arg0) {
        return java.util.function.Predicate.super.and(arg0);
    }
    //@Override
    public java.util.function.Predicate negate() {
        raiseEvent("negate"); Object retVal = getReturnData(); return (java.util.function.Predicate)retVal;
    }
    //@Override
    public java.util.function.Predicate negateDefault() {
        return java.util.function.Predicate.super.negate();
    }
    //@Override
    public java.util.function.Predicate or(java.util.function.Predicate arg0) {
        raiseEvent("or", arg0); Object retVal = getReturnData(); return (java.util.function.Predicate)retVal;
    }
    //@Override
    public java.util.function.Predicate orDefault(java.util.function.Predicate arg0) {
        return java.util.function.Predicate.super.or(arg0);
    }

}