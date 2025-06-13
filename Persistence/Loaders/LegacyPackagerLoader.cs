using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000258 RID: 600
	public class LegacyPackagerLoader : LegacyEmployeeLoader
	{
		// Token: 0x06002F2E RID: 12078 RVA: 0x00109D90 File Offset: 0x00107F90
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyPackagerLoader()
		{
			Il2CppClassPointerStore<LegacyPackagerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "LegacyPackagerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyPackagerLoader>.NativeClassPtr);
			LegacyPackagerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyPackagerLoader>.NativeClassPtr, 100668804);
			LegacyPackagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyPackagerLoader>.NativeClassPtr, 100668805);
			LegacyPackagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyPackagerLoader>.NativeClassPtr, 100668806);
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06002F2F RID: 12079 RVA: 0x00109DFC File Offset: 0x00107FFC
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133362, XrefRangeEnd = 133369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyPackagerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x00109E40 File Offset: 0x00108040
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 133122, RefRangeEnd = 133137, XrefRangeStart = 133122, XrefRangeEnd = 133137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LegacyPackagerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyPackagerLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyPackagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x00109E7C File Offset: 0x0010807C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133369, XrefRangeEnd = 133441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyPackagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x00018EAF File Offset: 0x000170AF
		public LegacyPackagerLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F3F RID: 7999
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001F40 RID: 8000
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F41 RID: 8001
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x02000942 RID: 2370
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyPackagerLoader+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CA5A RID: 51802 RVA: 0x00315910 File Offset: 0x00313B10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyPackagerLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_0>.NativeClassPtr);
				LegacyPackagerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_packager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_0>.NativeClassPtr, "packager");
				LegacyPackagerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668807);
			}

			// Token: 0x0600CA5B RID: 51803 RVA: 0x00315964 File Offset: 0x00313B64
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyPackagerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA5C RID: 51804 RVA: 0x00062236 File Offset: 0x00060436
			public __c__DisplayClass3_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ED0 RID: 16080
			// (get) Token: 0x0600CA5D RID: 51805 RVA: 0x003159A0 File Offset: 0x00313BA0
			// (set) Token: 0x0600CA5E RID: 51806 RVA: 0x0006223F File Offset: 0x0006043F
			public unsafe Packager packager
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyPackagerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_packager);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyPackagerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_packager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008931 RID: 35121
			private static readonly System.IntPtr NativeFieldInfoPtr_packager;

			// Token: 0x04008932 RID: 35122
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000943 RID: 2371
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyPackagerLoader+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : Il2CppSystem.Object
		{
			// Token: 0x0600CA5F RID: 51807 RVA: 0x003159D0 File Offset: 0x00313BD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyPackagerLoader>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_1>.NativeClassPtr);
				LegacyPackagerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_1>.NativeClassPtr, "configData");
				LegacyPackagerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_1>.NativeClassPtr, "CS$<>8__locals1");
				LegacyPackagerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668808);
				LegacyPackagerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668809);
			}

			// Token: 0x0600CA60 RID: 51808 RVA: 0x00315A4C File Offset: 0x00313C4C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_1>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyPackagerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA61 RID: 51809 RVA: 0x00315A88 File Offset: 0x00313C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133331, XrefRangeEnd = 133349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyPackagerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA62 RID: 51810 RVA: 0x0006225E File Offset: 0x0006045E
			public __c__DisplayClass3_1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ED1 RID: 16081
			// (get) Token: 0x0600CA63 RID: 51811 RVA: 0x00315ABC File Offset: 0x00313CBC
			// (set) Token: 0x0600CA64 RID: 51812 RVA: 0x00062267 File Offset: 0x00060467
			public unsafe PackagerConfigurationData configData
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyPackagerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagerConfigurationData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyPackagerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ED2 RID: 16082
			// (get) Token: 0x0600CA65 RID: 51813 RVA: 0x00315AEC File Offset: 0x00313CEC
			// (set) Token: 0x0600CA66 RID: 51814 RVA: 0x00062286 File Offset: 0x00060486
			public unsafe LegacyPackagerLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyPackagerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LegacyPackagerLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyPackagerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008933 RID: 35123
			private static readonly System.IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x04008934 RID: 35124
			private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x04008935 RID: 35125
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008936 RID: 35126
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000944 RID: 2372
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyPackagerLoader+<>c__DisplayClass3_2")]
		public sealed class __c__DisplayClass3_2 : Il2CppSystem.Object
		{
			// Token: 0x0600CA67 RID: 51815 RVA: 0x00315B1C File Offset: 0x00313D1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_2()
			{
				Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyPackagerLoader>.NativeClassPtr, "<>c__DisplayClass3_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_2>.NativeClassPtr);
				LegacyPackagerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_2>.NativeClassPtr, "data");
				LegacyPackagerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_2>.NativeClassPtr, "CS$<>8__locals2");
				LegacyPackagerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668810);
				LegacyPackagerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668811);
			}

			// Token: 0x0600CA68 RID: 51816 RVA: 0x00315B98 File Offset: 0x00313D98
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyPackagerLoader.__c__DisplayClass3_2>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyPackagerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA69 RID: 51817 RVA: 0x00315BD4 File Offset: 0x00313DD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133349, XrefRangeEnd = 133362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyPackagerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA6A RID: 51818 RVA: 0x000622A5 File Offset: 0x000604A5
			public __c__DisplayClass3_2(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ED3 RID: 16083
			// (get) Token: 0x0600CA6B RID: 51819 RVA: 0x00315C08 File Offset: 0x00313E08
			// (set) Token: 0x0600CA6C RID: 51820 RVA: 0x000622AE File Offset: 0x000604AE
			public unsafe PackagerData data
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyPackagerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagerData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyPackagerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ED4 RID: 16084
			// (get) Token: 0x0600CA6D RID: 51821 RVA: 0x00315C38 File Offset: 0x00313E38
			// (set) Token: 0x0600CA6E RID: 51822 RVA: 0x000622CD File Offset: 0x000604CD
			public unsafe LegacyPackagerLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyPackagerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LegacyPackagerLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyPackagerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008937 RID: 35127
			private static readonly System.IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04008938 RID: 35128
			private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x04008939 RID: 35129
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400893A RID: 35130
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
