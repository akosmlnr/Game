using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000276 RID: 630
	[System.Serializable]
	public class DynamicSaveData : SaveData
	{
		// Token: 0x06003015 RID: 12309 RVA: 0x0010D568 File Offset: 0x0010B768
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicSaveData()
		{
			Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DynamicSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr);
			DynamicSaveData.NativeFieldInfoPtr_BaseData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, "BaseData");
			DynamicSaveData.NativeFieldInfoPtr_AdditionalDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, "AdditionalDatas");
			DynamicSaveData.NativeMethodInfoPtr__ctor_Public_Void_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100668963);
			DynamicSaveData.NativeMethodInfoPtr_AddData_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100668964);
			DynamicSaveData.NativeMethodInfoPtr_AddData_Public_Void_String_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100668965);
			DynamicSaveData.NativeMethodInfoPtr_GetData_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100668966);
			DynamicSaveData.NativeMethodInfoPtr_TryGetData_Public_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100668967);
			DynamicSaveData.NativeMethodInfoPtr_GetData_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100668968);
			DynamicSaveData.NativeMethodInfoPtr_TryGetData_Public_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100668969);
			DynamicSaveData.NativeMethodInfoPtr_ExtractBaseData_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100668970);
			DynamicSaveData.NativeMethodInfoPtr_TryExtractBaseData_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100668971);
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x0010D674 File Offset: 0x0010B874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136276, RefRangeEnd = 136277, XrefRangeStart = 136261, XrefRangeEnd = 136276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicSaveData(SaveData baseData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.NativeMethodInfoPtr__ctor_Public_Void_SaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x0010D6C0 File Offset: 0x0010B8C0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 136297, RefRangeEnd = 136315, XrefRangeStart = 136277, XrefRangeEnd = 136297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(string name, string contents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contents);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.NativeMethodInfoPtr_AddData_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x0010D714 File Offset: 0x0010B914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136315, XrefRangeEnd = 136317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(string name, SaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.NativeMethodInfoPtr_AddData_Public_Void_String_SaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x0010D768 File Offset: 0x0010B968
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 136329, RefRangeEnd = 136334, XrefRangeStart = 136317, XrefRangeEnd = 136329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetData(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.NativeMethodInfoPtr_GetData_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x0010D7B0 File Offset: 0x0010B9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136334, XrefRangeEnd = 136348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetData(string name, out string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.NativeMethodInfoPtr_TryGetData_Public_Boolean_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			data = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x0010D818 File Offset: 0x0010BA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136348, XrefRangeEnd = 136362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetData<T>(string name) where T : SaveData
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			System.IntPtr returnedException;
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.MethodInfoStoreGeneric_GetData_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x0010D864 File Offset: 0x0010BA64
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 136390, RefRangeEnd = 136406, XrefRangeStart = 136362, XrefRangeEnd = 136390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetData<T>(string name, out T data) where T : SaveData
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
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
				intPtr2 = ref data;
			}
			ptr2 = intPtr2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.MethodInfoStoreGeneric_TryGetData_Public_Boolean_String_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			if (!typeof(T).IsValueType)
			{
				System.IntPtr intPtr3 = intPtr;
				data = ((intPtr3 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr3, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x0010D900 File Offset: 0x0010BB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136406, XrefRangeEnd = 136416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T ExtractBaseData<T>() where T : SaveData
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.MethodInfoStoreGeneric_ExtractBaseData_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x0010D93C File Offset: 0x0010BB3C
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 136436, RefRangeEnd = 136474, XrefRangeStart = 136416, XrefRangeEnd = 136436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryExtractBaseData<T>(out T data) where T : SaveData
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr intPtr;
			System.IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref data;
			}
			ptr2 = intPtr2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.MethodInfoStoreGeneric_TryExtractBaseData_Public_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			if (!typeof(T).IsValueType)
			{
				System.IntPtr intPtr3 = intPtr;
				data = ((intPtr3 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr3, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x000192C2 File Offset: 0x000174C2
		public DynamicSaveData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06003020 RID: 12320 RVA: 0x0010D9C8 File Offset: 0x0010BBC8
		// (set) Token: 0x06003021 RID: 12321 RVA: 0x000192CB File Offset: 0x000174CB
		public unsafe string BaseData
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.NativeFieldInfoPtr_BaseData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.NativeFieldInfoPtr_BaseData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06003022 RID: 12322 RVA: 0x0010D9F0 File Offset: 0x0010BBF0
		// (set) Token: 0x06003023 RID: 12323 RVA: 0x000192EA File Offset: 0x000174EA
		public unsafe List<DynamicSaveData.AdditionalData> AdditionalDatas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.NativeFieldInfoPtr_AdditionalDatas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DynamicSaveData.AdditionalData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.NativeFieldInfoPtr_AdditionalDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FCF RID: 8143
		private static readonly System.IntPtr NativeFieldInfoPtr_BaseData;

		// Token: 0x04001FD0 RID: 8144
		private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalDatas;

		// Token: 0x04001FD1 RID: 8145
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SaveData_0;

		// Token: 0x04001FD2 RID: 8146
		private static readonly System.IntPtr NativeMethodInfoPtr_AddData_Public_Void_String_String_0;

		// Token: 0x04001FD3 RID: 8147
		private static readonly System.IntPtr NativeMethodInfoPtr_AddData_Public_Void_String_SaveData_0;

		// Token: 0x04001FD4 RID: 8148
		private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_String_String_0;

		// Token: 0x04001FD5 RID: 8149
		private static readonly System.IntPtr NativeMethodInfoPtr_TryGetData_Public_Boolean_String_byref_String_0;

		// Token: 0x04001FD6 RID: 8150
		private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_T_String_0;

		// Token: 0x04001FD7 RID: 8151
		private static readonly System.IntPtr NativeMethodInfoPtr_TryGetData_Public_Boolean_String_byref_T_0;

		// Token: 0x04001FD8 RID: 8152
		private static readonly System.IntPtr NativeMethodInfoPtr_ExtractBaseData_Public_T_0;

		// Token: 0x04001FD9 RID: 8153
		private static readonly System.IntPtr NativeMethodInfoPtr_TryExtractBaseData_Public_Boolean_byref_T_0;

		// Token: 0x02000958 RID: 2392
		[System.Serializable]
		public class AdditionalData : Il2CppSystem.Object
		{
			// Token: 0x0600CB01 RID: 51969 RVA: 0x00317478 File Offset: 0x00315678
			// Note: this type is marked as 'beforefieldinit'.
			static AdditionalData()
			{
				Il2CppClassPointerStore<DynamicSaveData.AdditionalData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, "AdditionalData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicSaveData.AdditionalData>.NativeClassPtr);
				DynamicSaveData.AdditionalData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicSaveData.AdditionalData>.NativeClassPtr, "Name");
				DynamicSaveData.AdditionalData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicSaveData.AdditionalData>.NativeClassPtr, "Contents");
				DynamicSaveData.AdditionalData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData.AdditionalData>.NativeClassPtr, 100668972);
			}

			// Token: 0x0600CB02 RID: 51970 RVA: 0x003174E0 File Offset: 0x003156E0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdditionalData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicSaveData.AdditionalData>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.AdditionalData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CB03 RID: 51971 RVA: 0x000627EA File Offset: 0x000609EA
			public AdditionalData(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF9 RID: 16121
			// (get) Token: 0x0600CB04 RID: 51972 RVA: 0x0031751C File Offset: 0x0031571C
			// (set) Token: 0x0600CB05 RID: 51973 RVA: 0x000627F3 File Offset: 0x000609F3
			public unsafe string Name
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.AdditionalData.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.AdditionalData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003EFA RID: 16122
			// (get) Token: 0x0600CB06 RID: 51974 RVA: 0x00317544 File Offset: 0x00315744
			// (set) Token: 0x0600CB07 RID: 51975 RVA: 0x00062812 File Offset: 0x00060A12
			public unsafe string Contents
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.AdditionalData.NativeFieldInfoPtr_Contents);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.AdditionalData.NativeFieldInfoPtr_Contents), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008985 RID: 35205
			private static readonly System.IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04008986 RID: 35206
			private static readonly System.IntPtr NativeFieldInfoPtr_Contents;

			// Token: 0x04008987 RID: 35207
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000959 RID: 2393
		private sealed class MethodInfoStoreGeneric_GetData_Public_T_String_0<T>
		{
			// Token: 0x04008988 RID: 35208
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynamicSaveData.NativeMethodInfoPtr_GetData_Public_T_String_0, Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200095A RID: 2394
		private sealed class MethodInfoStoreGeneric_TryGetData_Public_Boolean_String_byref_T_0<T>
		{
			// Token: 0x04008989 RID: 35209
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynamicSaveData.NativeMethodInfoPtr_TryGetData_Public_Boolean_String_byref_T_0, Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200095B RID: 2395
		private sealed class MethodInfoStoreGeneric_ExtractBaseData_Public_T_0<T>
		{
			// Token: 0x0400898A RID: 35210
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynamicSaveData.NativeMethodInfoPtr_ExtractBaseData_Public_T_0, Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200095C RID: 2396
		private sealed class MethodInfoStoreGeneric_TryExtractBaseData_Public_Boolean_byref_T_0<T>
		{
			// Token: 0x0400898B RID: 35211
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynamicSaveData.NativeMethodInfoPtr_TryExtractBaseData_Public_Boolean_byref_T_0, Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
