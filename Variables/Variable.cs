using System;
using Il2CppFishNet.Connection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x0200018C RID: 396
	public class Variable<T> : BaseVariable
	{
		// Token: 0x06001F27 RID: 7975 RVA: 0x000D456C File Offset: 0x000D276C
		// Note: this type is marked as 'beforefieldinit'.
		static Variable()
		{
			Il2CppClassPointerStore<Variable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "Variable`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr);
			Variable<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, "Value");
			Variable<T>.NativeFieldInfoPtr_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, "OnValueChanged");
			Variable<T>.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100666853);
			Variable<T>.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100666854);
			Variable<T>.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100666855);
			Variable<T>.NativeMethodInfoPtr_TryDeserialize_Public_Virtual_New_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100666856);
			Variable<T>.NativeMethodInfoPtr_ReplicateValue_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100666857);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x000D4664 File Offset: 0x000D2864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110966, RefRangeEnd = 110968, XrefRangeStart = 110952, XrefRangeEnd = 110966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Variable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, T value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref replicationMode;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref persistent;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mode;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			System.IntPtr returnedException;
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Variable<T>.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x000D4738 File Offset: 0x000D2938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110968, XrefRangeEnd = 110969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppSystem.Object GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Variable<T>.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x000D4784 File Offset: 0x000D2984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110969, XrefRangeEnd = 111003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(Il2CppSystem.Object value, bool replicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref replicate;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Variable<T>.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x000D47E0 File Offset: 0x000D29E0
		[CallerCount(0)]
		public unsafe virtual bool TryDeserialize(string valueString, out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(valueString);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr;
			System.IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Variable<T>.NativeMethodInfoPtr_TryDeserialize_Public_Virtual_New_Boolean_String_byref_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			if (!typeof(T).IsValueType)
			{
				System.IntPtr intPtr3 = intPtr;
				value = ((intPtr3 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr3, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x000D4888 File Offset: 0x000D2A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111003, XrefRangeEnd = 111011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReplicateValue(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Variable<T>.NativeMethodInfoPtr_ReplicateValue_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00011736 File Offset: 0x0000F936
		public Variable(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06001F2E RID: 7982 RVA: 0x000D48D8 File Offset: 0x000D2AD8
		// (set) Token: 0x06001F2F RID: 7983 RVA: 0x000D4900 File Offset: 0x000D2B00
		public unsafe T Value
		{
			get
			{
				System.IntPtr objectPointer = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Variable<T>.NativeFieldInfoPtr_Value);
				return IL2CPP.PointerToValueGeneric<T>(objectPointer, true, false);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr intPtr2 = intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Variable<T>.NativeFieldInfoPtr_Value);
				System.Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						System.IntPtr gcObj;
						System.IntPtr intPtr3 = gcObj = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
						if (intPtr3 != 0)
						{
							gcObj = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								System.IntPtr obj = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(obj), (System.UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, gcObj);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06001F30 RID: 7984 RVA: 0x000D49A8 File Offset: 0x000D2BA8
		// (set) Token: 0x06001F31 RID: 7985 RVA: 0x0001173F File Offset: 0x0000F93F
		public unsafe UnityEvent<T> OnValueChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Variable<T>.NativeFieldInfoPtr_OnValueChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<T>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Variable<T>.NativeFieldInfoPtr_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014B1 RID: 5297
		private static readonly System.IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x040014B2 RID: 5298
		private static readonly System.IntPtr NativeFieldInfoPtr_OnValueChanged;

		// Token: 0x040014B3 RID: 5299
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_T_0;

		// Token: 0x040014B4 RID: 5300
		private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_0;

		// Token: 0x040014B5 RID: 5301
		private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Boolean_0;

		// Token: 0x040014B6 RID: 5302
		private static readonly System.IntPtr NativeMethodInfoPtr_TryDeserialize_Public_Virtual_New_Boolean_String_byref_T_0;

		// Token: 0x040014B7 RID: 5303
		private static readonly System.IntPtr NativeMethodInfoPtr_ReplicateValue_Public_Virtual_Void_NetworkConnection_0;
	}
}
