using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200025A RID: 602
	public class PackagerLoader : EmployeeLoader
	{
		// Token: 0x06002F38 RID: 12088 RVA: 0x0010A008 File Offset: 0x00108208
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerLoader()
		{
			Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "PackagerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr);
			PackagerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr, 100668817);
			PackagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr, 100668818);
			PackagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr, 100668819);
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06002F39 RID: 12089 RVA: 0x0010A074 File Offset: 0x00108274
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133582, XrefRangeEnd = 133589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x0010A0B8 File Offset: 0x001082B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133590, RefRangeEnd = 133592, XrefRangeStart = 133589, XrefRangeEnd = 133590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x0010A0F4 File Offset: 0x001082F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133592, XrefRangeEnd = 133637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x00018EC1 File Offset: 0x000170C1
		public PackagerLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F45 RID: 8005
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001F46 RID: 8006
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F47 RID: 8007
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0;

		// Token: 0x02000946 RID: 2374
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.PackagerLoader+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CA75 RID: 51829 RVA: 0x00315D8C File Offset: 0x00313F8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_0>.NativeClassPtr);
				PackagerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_packager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_0>.NativeClassPtr, "packager");
				PackagerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_0>.NativeClassPtr, "configData");
				PackagerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_0>.NativeClassPtr, "data");
				PackagerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668820);
				PackagerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668821);
				PackagerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668822);
			}

			// Token: 0x0600CA76 RID: 51830 RVA: 0x00315E30 File Offset: 0x00314030
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA77 RID: 51831 RVA: 0x00315E6C File Offset: 0x0031406C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133551, XrefRangeEnd = 133569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA78 RID: 51832 RVA: 0x00315EA0 File Offset: 0x003140A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133569, XrefRangeEnd = 133582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA79 RID: 51833 RVA: 0x00062314 File Offset: 0x00060514
			public __c__DisplayClass3_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ED6 RID: 16086
			// (get) Token: 0x0600CA7A RID: 51834 RVA: 0x00315ED4 File Offset: 0x003140D4
			// (set) Token: 0x0600CA7B RID: 51835 RVA: 0x0006231D File Offset: 0x0006051D
			public unsafe Packager packager
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_packager);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_packager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ED7 RID: 16087
			// (get) Token: 0x0600CA7C RID: 51836 RVA: 0x00315F04 File Offset: 0x00314104
			// (set) Token: 0x0600CA7D RID: 51837 RVA: 0x0006233C File Offset: 0x0006053C
			public unsafe PackagerConfigurationData configData
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagerConfigurationData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ED8 RID: 16088
			// (get) Token: 0x0600CA7E RID: 51838 RVA: 0x00315F34 File Offset: 0x00314134
			// (set) Token: 0x0600CA7F RID: 51839 RVA: 0x0006235B File Offset: 0x0006055B
			public unsafe PackagerData data
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagerData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400893E RID: 35134
			private static readonly System.IntPtr NativeFieldInfoPtr_packager;

			// Token: 0x0400893F RID: 35135
			private static readonly System.IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x04008940 RID: 35136
			private static readonly System.IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04008941 RID: 35137
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008942 RID: 35138
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04008943 RID: 35139
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;
		}
	}
}
