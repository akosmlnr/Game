using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027B RID: 635
	[System.Serializable]
	public class GenericSaveData : SaveData
	{
		// Token: 0x06003044 RID: 12356 RVA: 0x0010DF80 File Offset: 0x0010C180
		// Note: this type is marked as 'beforefieldinit'.
		static GenericSaveData()
		{
			Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GenericSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr);
			GenericSaveData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "GUID");
			GenericSaveData.NativeFieldInfoPtr_boolValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "boolValues");
			GenericSaveData.NativeFieldInfoPtr_floatValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "floatValues");
			GenericSaveData.NativeFieldInfoPtr_intValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "intValues");
			GenericSaveData.NativeFieldInfoPtr_stringValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "stringValues");
			GenericSaveData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668979);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668980);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668981);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668982);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668983);
			GenericSaveData.NativeMethodInfoPtr_GetBool_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668984);
			GenericSaveData.NativeMethodInfoPtr_GetFloat_Public_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668985);
			GenericSaveData.NativeMethodInfoPtr_GetInt_Public_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668986);
			GenericSaveData.NativeMethodInfoPtr_GetString_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668987);
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x0010E0C8 File Offset: 0x0010C2C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136531, RefRangeEnd = 136533, XrefRangeStart = 136498, XrefRangeEnd = 136531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericSaveData(string guid) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x0010E114 File Offset: 0x0010C314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136541, RefRangeEnd = 136543, XrefRangeStart = 136533, XrefRangeEnd = 136541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x0010E164 File Offset: 0x0010C364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136543, XrefRangeEnd = 136551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x0010E1B4 File Offset: 0x0010C3B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136559, RefRangeEnd = 136561, XrefRangeStart = 136551, XrefRangeEnd = 136559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x0010E204 File Offset: 0x0010C404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136561, XrefRangeEnd = 136570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x0010E258 File Offset: 0x0010C458
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136584, RefRangeEnd = 136586, XrefRangeStart = 136570, XrefRangeEnd = 136584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBool(string key, bool defaultValue = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref defaultValue;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetBool_Public_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x0010E2B4 File Offset: 0x0010C4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136586, XrefRangeEnd = 136600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFloat(string key, float defaultValue = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref defaultValue;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetFloat_Public_Single_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x0010E310 File Offset: 0x0010C510
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136614, RefRangeEnd = 136616, XrefRangeStart = 136600, XrefRangeEnd = 136614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInt(string key, int defaultValue = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref defaultValue;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetInt_Public_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x0010E36C File Offset: 0x0010C56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136616, XrefRangeEnd = 136630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(string key, string defaultValue = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetString_Public_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x00019430 File Offset: 0x00017630
		public GenericSaveData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x0600304F RID: 12367 RVA: 0x0010E3C8 File Offset: 0x0010C5C8
		// (set) Token: 0x06003050 RID: 12368 RVA: 0x00019439 File Offset: 0x00017639
		public unsafe string GUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06003051 RID: 12369 RVA: 0x0010E3F0 File Offset: 0x0010C5F0
		// (set) Token: 0x06003052 RID: 12370 RVA: 0x00019458 File Offset: 0x00017658
		public unsafe List<GenericSaveData.BoolValue> boolValues
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_boolValues);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.BoolValue>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_boolValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06003053 RID: 12371 RVA: 0x0010E420 File Offset: 0x0010C620
		// (set) Token: 0x06003054 RID: 12372 RVA: 0x00019477 File Offset: 0x00017677
		public unsafe List<GenericSaveData.FloatValue> floatValues
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_floatValues);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.FloatValue>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_floatValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06003055 RID: 12373 RVA: 0x0010E450 File Offset: 0x0010C650
		// (set) Token: 0x06003056 RID: 12374 RVA: 0x00019496 File Offset: 0x00017696
		public unsafe List<GenericSaveData.IntValue> intValues
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_intValues);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.IntValue>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_intValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06003057 RID: 12375 RVA: 0x0010E480 File Offset: 0x0010C680
		// (set) Token: 0x06003058 RID: 12376 RVA: 0x000194B5 File Offset: 0x000176B5
		public unsafe List<GenericSaveData.StringValue> stringValues
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_stringValues);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.StringValue>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_stringValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FE9 RID: 8169
		private static readonly System.IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04001FEA RID: 8170
		private static readonly System.IntPtr NativeFieldInfoPtr_boolValues;

		// Token: 0x04001FEB RID: 8171
		private static readonly System.IntPtr NativeFieldInfoPtr_floatValues;

		// Token: 0x04001FEC RID: 8172
		private static readonly System.IntPtr NativeFieldInfoPtr_intValues;

		// Token: 0x04001FED RID: 8173
		private static readonly System.IntPtr NativeFieldInfoPtr_stringValues;

		// Token: 0x04001FEE RID: 8174
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001FEF RID: 8175
		private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Boolean_0;

		// Token: 0x04001FF0 RID: 8176
		private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Single_0;

		// Token: 0x04001FF1 RID: 8177
		private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Int32_0;

		// Token: 0x04001FF2 RID: 8178
		private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_String_String_0;

		// Token: 0x04001FF3 RID: 8179
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBool_Public_Boolean_String_Boolean_0;

		// Token: 0x04001FF4 RID: 8180
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_String_Single_0;

		// Token: 0x04001FF5 RID: 8181
		private static readonly System.IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_String_Int32_0;

		// Token: 0x04001FF6 RID: 8182
		private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Public_String_String_String_0;

		// Token: 0x0200095D RID: 2397
		[System.Serializable]
		public class BoolValue : Il2CppSystem.Object
		{
			// Token: 0x0600CB0C RID: 51980 RVA: 0x003176BC File Offset: 0x003158BC
			// Note: this type is marked as 'beforefieldinit'.
			static BoolValue()
			{
				Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "BoolValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr);
				GenericSaveData.BoolValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr, "key");
				GenericSaveData.BoolValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr, "value");
				GenericSaveData.BoolValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr, 100668988);
			}

			// Token: 0x0600CB0D RID: 51981 RVA: 0x00317724 File Offset: 0x00315924
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BoolValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.BoolValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CB0E RID: 51982 RVA: 0x00062831 File Offset: 0x00060A31
			public BoolValue(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EFB RID: 16123
			// (get) Token: 0x0600CB0F RID: 51983 RVA: 0x00317760 File Offset: 0x00315960
			// (set) Token: 0x0600CB10 RID: 51984 RVA: 0x0006283A File Offset: 0x00060A3A
			public unsafe string key
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003EFC RID: 16124
			// (get) Token: 0x0600CB11 RID: 51985 RVA: 0x00317788 File Offset: 0x00315988
			// (set) Token: 0x0600CB12 RID: 51986 RVA: 0x00062859 File Offset: 0x00060A59
			public unsafe bool value
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x0400898C RID: 35212
			private static readonly System.IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400898D RID: 35213
			private static readonly System.IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400898E RID: 35214
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200095E RID: 2398
		[System.Serializable]
		public class FloatValue : Il2CppSystem.Object
		{
			// Token: 0x0600CB13 RID: 51987 RVA: 0x003177B0 File Offset: 0x003159B0
			// Note: this type is marked as 'beforefieldinit'.
			static FloatValue()
			{
				Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "FloatValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr);
				GenericSaveData.FloatValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr, "key");
				GenericSaveData.FloatValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr, "value");
				GenericSaveData.FloatValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr, 100668989);
			}

			// Token: 0x0600CB14 RID: 51988 RVA: 0x00317818 File Offset: 0x00315A18
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FloatValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.FloatValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CB15 RID: 51989 RVA: 0x00062874 File Offset: 0x00060A74
			public FloatValue(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EFD RID: 16125
			// (get) Token: 0x0600CB16 RID: 51990 RVA: 0x00317854 File Offset: 0x00315A54
			// (set) Token: 0x0600CB17 RID: 51991 RVA: 0x0006287D File Offset: 0x00060A7D
			public unsafe string key
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003EFE RID: 16126
			// (get) Token: 0x0600CB18 RID: 51992 RVA: 0x0031787C File Offset: 0x00315A7C
			// (set) Token: 0x0600CB19 RID: 51993 RVA: 0x0006289C File Offset: 0x00060A9C
			public unsafe float value
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x0400898F RID: 35215
			private static readonly System.IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04008990 RID: 35216
			private static readonly System.IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04008991 RID: 35217
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200095F RID: 2399
		[System.Serializable]
		public class IntValue : Il2CppSystem.Object
		{
			// Token: 0x0600CB1A RID: 51994 RVA: 0x003178A4 File Offset: 0x00315AA4
			// Note: this type is marked as 'beforefieldinit'.
			static IntValue()
			{
				Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "IntValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr);
				GenericSaveData.IntValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr, "key");
				GenericSaveData.IntValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr, "value");
				GenericSaveData.IntValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr, 100668990);
			}

			// Token: 0x0600CB1B RID: 51995 RVA: 0x0031790C File Offset: 0x00315B0C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.IntValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CB1C RID: 51996 RVA: 0x000628B7 File Offset: 0x00060AB7
			public IntValue(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EFF RID: 16127
			// (get) Token: 0x0600CB1D RID: 51997 RVA: 0x00317948 File Offset: 0x00315B48
			// (set) Token: 0x0600CB1E RID: 51998 RVA: 0x000628C0 File Offset: 0x00060AC0
			public unsafe string key
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F00 RID: 16128
			// (get) Token: 0x0600CB1F RID: 51999 RVA: 0x00317970 File Offset: 0x00315B70
			// (set) Token: 0x0600CB20 RID: 52000 RVA: 0x000628DF File Offset: 0x00060ADF
			public unsafe int value
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x04008992 RID: 35218
			private static readonly System.IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04008993 RID: 35219
			private static readonly System.IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04008994 RID: 35220
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000960 RID: 2400
		[System.Serializable]
		public class StringValue : Il2CppSystem.Object
		{
			// Token: 0x0600CB21 RID: 52001 RVA: 0x00317998 File Offset: 0x00315B98
			// Note: this type is marked as 'beforefieldinit'.
			static StringValue()
			{
				Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "StringValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr);
				GenericSaveData.StringValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr, "key");
				GenericSaveData.StringValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr, "value");
				GenericSaveData.StringValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr, 100668991);
			}

			// Token: 0x0600CB22 RID: 52002 RVA: 0x00317A00 File Offset: 0x00315C00
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.StringValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CB23 RID: 52003 RVA: 0x000628FA File Offset: 0x00060AFA
			public StringValue(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F01 RID: 16129
			// (get) Token: 0x0600CB24 RID: 52004 RVA: 0x00317A3C File Offset: 0x00315C3C
			// (set) Token: 0x0600CB25 RID: 52005 RVA: 0x00062903 File Offset: 0x00060B03
			public unsafe string key
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F02 RID: 16130
			// (get) Token: 0x0600CB26 RID: 52006 RVA: 0x00317A64 File Offset: 0x00315C64
			// (set) Token: 0x0600CB27 RID: 52007 RVA: 0x00062922 File Offset: 0x00060B22
			public unsafe string value
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008995 RID: 35221
			private static readonly System.IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04008996 RID: 35222
			private static readonly System.IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04008997 RID: 35223
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000961 RID: 2401
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CB28 RID: 52008 RVA: 0x00317A8C File Offset: 0x00315C8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass14_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr, 100668992);
				GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__GetBool_b__0_Internal_Boolean_BoolValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr, 100668993);
			}

			// Token: 0x0600CB29 RID: 52009 RVA: 0x00317AF4 File Offset: 0x00315CF4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CB2A RID: 52010 RVA: 0x00317B30 File Offset: 0x00315D30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBool_b__0(GenericSaveData.BoolValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__GetBool_b__0_Internal_Boolean_BoolValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CB2B RID: 52011 RVA: 0x00062941 File Offset: 0x00060B41
			public __c__DisplayClass14_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F03 RID: 16131
			// (get) Token: 0x0600CB2C RID: 52012 RVA: 0x00317B80 File Offset: 0x00315D80
			// (set) Token: 0x0600CB2D RID: 52013 RVA: 0x0006294A File Offset: 0x00060B4A
			public unsafe string key
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass14_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass14_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008998 RID: 35224
			private static readonly System.IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04008999 RID: 35225
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400899A RID: 35226
			private static readonly System.IntPtr NativeMethodInfoPtr__GetBool_b__0_Internal_Boolean_BoolValue_0;
		}

		// Token: 0x02000962 RID: 2402
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CB2E RID: 52014 RVA: 0x00317BA8 File Offset: 0x00315DA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass15_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr, 100668994);
				GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__GetFloat_b__0_Internal_Boolean_FloatValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr, 100668995);
			}

			// Token: 0x0600CB2F RID: 52015 RVA: 0x00317C10 File Offset: 0x00315E10
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CB30 RID: 52016 RVA: 0x00317C4C File Offset: 0x00315E4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFloat_b__0(GenericSaveData.FloatValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__GetFloat_b__0_Internal_Boolean_FloatValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CB31 RID: 52017 RVA: 0x00062969 File Offset: 0x00060B69
			public __c__DisplayClass15_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F04 RID: 16132
			// (get) Token: 0x0600CB32 RID: 52018 RVA: 0x00317C9C File Offset: 0x00315E9C
			// (set) Token: 0x0600CB33 RID: 52019 RVA: 0x00062972 File Offset: 0x00060B72
			public unsafe string key
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass15_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass15_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400899B RID: 35227
			private static readonly System.IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400899C RID: 35228
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400899D RID: 35229
			private static readonly System.IntPtr NativeMethodInfoPtr__GetFloat_b__0_Internal_Boolean_FloatValue_0;
		}

		// Token: 0x02000963 RID: 2403
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CB34 RID: 52020 RVA: 0x00317CC4 File Offset: 0x00315EC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass16_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr, 100668996);
				GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__GetInt_b__0_Internal_Boolean_IntValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr, 100668997);
			}

			// Token: 0x0600CB35 RID: 52021 RVA: 0x00317D2C File Offset: 0x00315F2C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CB36 RID: 52022 RVA: 0x00317D68 File Offset: 0x00315F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetInt_b__0(GenericSaveData.IntValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__GetInt_b__0_Internal_Boolean_IntValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CB37 RID: 52023 RVA: 0x00062991 File Offset: 0x00060B91
			public __c__DisplayClass16_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F05 RID: 16133
			// (get) Token: 0x0600CB38 RID: 52024 RVA: 0x00317DB8 File Offset: 0x00315FB8
			// (set) Token: 0x0600CB39 RID: 52025 RVA: 0x0006299A File Offset: 0x00060B9A
			public unsafe string key
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass16_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass16_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400899E RID: 35230
			private static readonly System.IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400899F RID: 35231
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089A0 RID: 35232
			private static readonly System.IntPtr NativeMethodInfoPtr__GetInt_b__0_Internal_Boolean_IntValue_0;
		}

		// Token: 0x02000964 RID: 2404
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CB3A RID: 52026 RVA: 0x00317DE0 File Offset: 0x00315FE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass17_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr, 100668998);
				GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__GetString_b__0_Internal_Boolean_StringValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr, 100668999);
			}

			// Token: 0x0600CB3B RID: 52027 RVA: 0x00317E48 File Offset: 0x00316048
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CB3C RID: 52028 RVA: 0x00317E84 File Offset: 0x00316084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetString_b__0(GenericSaveData.StringValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__GetString_b__0_Internal_Boolean_StringValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CB3D RID: 52029 RVA: 0x000629B9 File Offset: 0x00060BB9
			public __c__DisplayClass17_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F06 RID: 16134
			// (get) Token: 0x0600CB3E RID: 52030 RVA: 0x00317ED4 File Offset: 0x003160D4
			// (set) Token: 0x0600CB3F RID: 52031 RVA: 0x000629C2 File Offset: 0x00060BC2
			public unsafe string key
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass17_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass17_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040089A1 RID: 35233
			private static readonly System.IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040089A2 RID: 35234
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089A3 RID: 35235
			private static readonly System.IntPtr NativeMethodInfoPtr__GetString_b__0_Internal_Boolean_StringValue_0;
		}
	}
}
