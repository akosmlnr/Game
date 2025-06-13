using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000253 RID: 595
	public class LegacyBotanistLoader : LegacyEmployeeLoader
	{
		// Token: 0x06002F14 RID: 12052 RVA: 0x001096FC File Offset: 0x001078FC
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyBotanistLoader()
		{
			Il2CppClassPointerStore<LegacyBotanistLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "LegacyBotanistLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyBotanistLoader>.NativeClassPtr);
			LegacyBotanistLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyBotanistLoader>.NativeClassPtr, 100668771);
			LegacyBotanistLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyBotanistLoader>.NativeClassPtr, 100668772);
			LegacyBotanistLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyBotanistLoader>.NativeClassPtr, 100668773);
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x00109768 File Offset: 0x00107968
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132782, XrefRangeEnd = 132789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyBotanistLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x001097AC File Offset: 0x001079AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132789, XrefRangeEnd = 132790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LegacyBotanistLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyBotanistLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyBotanistLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x001097E8 File Offset: 0x001079E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132790, XrefRangeEnd = 132870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyBotanistLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x00018E82 File Offset: 0x00017082
		public LegacyBotanistLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F2F RID: 7983
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001F30 RID: 7984
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F31 RID: 7985
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x02000938 RID: 2360
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyBotanistLoader+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CA15 RID: 51733 RVA: 0x00314DE4 File Offset: 0x00312FE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyBotanistLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_0>.NativeClassPtr);
				LegacyBotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_botanist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, "botanist");
				LegacyBotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668774);
			}

			// Token: 0x0600CA16 RID: 51734 RVA: 0x00314E38 File Offset: 0x00313038
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyBotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA17 RID: 51735 RVA: 0x00061FEC File Offset: 0x000601EC
			public __c__DisplayClass3_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EC0 RID: 16064
			// (get) Token: 0x0600CA18 RID: 51736 RVA: 0x00314E74 File Offset: 0x00313074
			// (set) Token: 0x0600CA19 RID: 51737 RVA: 0x00061FF5 File Offset: 0x000601F5
			public unsafe Botanist botanist
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyBotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_botanist);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyBotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_botanist), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008910 RID: 35088
			private static readonly System.IntPtr NativeFieldInfoPtr_botanist;

			// Token: 0x04008911 RID: 35089
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000939 RID: 2361
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyBotanistLoader+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : Il2CppSystem.Object
		{
			// Token: 0x0600CA1A RID: 51738 RVA: 0x00314EA4 File Offset: 0x003130A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyBotanistLoader>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_1>.NativeClassPtr);
				LegacyBotanistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_1>.NativeClassPtr, "configData");
				LegacyBotanistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_1>.NativeClassPtr, "CS$<>8__locals1");
				LegacyBotanistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668775);
				LegacyBotanistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668776);
			}

			// Token: 0x0600CA1B RID: 51739 RVA: 0x00314F20 File Offset: 0x00313120
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_1>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyBotanistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA1C RID: 51740 RVA: 0x00314F5C File Offset: 0x0031315C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132751, XrefRangeEnd = 132769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyBotanistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA1D RID: 51741 RVA: 0x00062014 File Offset: 0x00060214
			public __c__DisplayClass3_1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EC1 RID: 16065
			// (get) Token: 0x0600CA1E RID: 51742 RVA: 0x00314F90 File Offset: 0x00313190
			// (set) Token: 0x0600CA1F RID: 51743 RVA: 0x0006201D File Offset: 0x0006021D
			public unsafe BotanistConfigurationData configData
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyBotanistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistConfigurationData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyBotanistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EC2 RID: 16066
			// (get) Token: 0x0600CA20 RID: 51744 RVA: 0x00314FC0 File Offset: 0x003131C0
			// (set) Token: 0x0600CA21 RID: 51745 RVA: 0x0006203C File Offset: 0x0006023C
			public unsafe LegacyBotanistLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyBotanistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LegacyBotanistLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyBotanistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008912 RID: 35090
			private static readonly System.IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x04008913 RID: 35091
			private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x04008914 RID: 35092
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008915 RID: 35093
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x0200093A RID: 2362
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyBotanistLoader+<>c__DisplayClass3_2")]
		public sealed class __c__DisplayClass3_2 : Il2CppSystem.Object
		{
			// Token: 0x0600CA22 RID: 51746 RVA: 0x00314FF0 File Offset: 0x003131F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_2()
			{
				Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyBotanistLoader>.NativeClassPtr, "<>c__DisplayClass3_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_2>.NativeClassPtr);
				LegacyBotanistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_2>.NativeClassPtr, "data");
				LegacyBotanistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_2>.NativeClassPtr, "CS$<>8__locals2");
				LegacyBotanistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668777);
				LegacyBotanistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668778);
			}

			// Token: 0x0600CA23 RID: 51747 RVA: 0x0031506C File Offset: 0x0031326C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyBotanistLoader.__c__DisplayClass3_2>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyBotanistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA24 RID: 51748 RVA: 0x003150A8 File Offset: 0x003132A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132769, XrefRangeEnd = 132782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyBotanistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CA25 RID: 51749 RVA: 0x0006205B File Offset: 0x0006025B
			public __c__DisplayClass3_2(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EC3 RID: 16067
			// (get) Token: 0x0600CA26 RID: 51750 RVA: 0x003150DC File Offset: 0x003132DC
			// (set) Token: 0x0600CA27 RID: 51751 RVA: 0x00062064 File Offset: 0x00060264
			public unsafe BotanistData data
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyBotanistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyBotanistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EC4 RID: 16068
			// (get) Token: 0x0600CA28 RID: 51752 RVA: 0x0031510C File Offset: 0x0031330C
			// (set) Token: 0x0600CA29 RID: 51753 RVA: 0x00062083 File Offset: 0x00060283
			public unsafe LegacyBotanistLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyBotanistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LegacyBotanistLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyBotanistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008916 RID: 35094
			private static readonly System.IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04008917 RID: 35095
			private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x04008918 RID: 35096
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008919 RID: 35097
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
