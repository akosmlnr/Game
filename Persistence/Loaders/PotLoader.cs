using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000266 RID: 614
	public class PotLoader : GridItemLoader
	{
		// Token: 0x06002F83 RID: 12163 RVA: 0x0010B4B0 File Offset: 0x001096B0
		// Note: this type is marked as 'beforefieldinit'.
		static PotLoader()
		{
			Il2CppClassPointerStore<PotLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "PotLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotLoader>.NativeClassPtr);
			PotLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotLoader>.NativeClassPtr, 100668899);
			PotLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotLoader>.NativeClassPtr, 100668900);
			PotLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotLoader>.NativeClassPtr, 100668901);
			PotLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotLoader>.NativeClassPtr, 100668902);
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06002F84 RID: 12164 RVA: 0x0010B530 File Offset: 0x00109730
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135273, XrefRangeEnd = 135280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x0010B574 File Offset: 0x00109774
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 133677, RefRangeEnd = 133696, XrefRangeStart = 133677, XrefRangeEnd = 133696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x0010B5B0 File Offset: 0x001097B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135280, XrefRangeEnd = 135337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x0010B600 File Offset: 0x00109800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135337, XrefRangeEnd = 135411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x00018F2D File Offset: 0x0001712D
		public PotLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F78 RID: 8056
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001F79 RID: 8057
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F7A RID: 8058
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001F7B RID: 8059
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0;

		// Token: 0x02000956 RID: 2390
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.PotLoader+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CAF1 RID: 51953 RVA: 0x003171E0 File Offset: 0x003153E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<PotLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotLoader.__c__DisplayClass3_0>.NativeClassPtr);
				PotLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_pot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotLoader.__c__DisplayClass3_0>.NativeClassPtr, "pot");
				PotLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotLoader.__c__DisplayClass3_0>.NativeClassPtr, "configData");
				PotLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668903);
				PotLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668904);
			}

			// Token: 0x0600CAF2 RID: 51954 RVA: 0x0031725C File Offset: 0x0031545C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CAF3 RID: 51955 RVA: 0x00317298 File Offset: 0x00315498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135233, XrefRangeEnd = 135253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CAF4 RID: 51956 RVA: 0x0006275C File Offset: 0x0006095C
			public __c__DisplayClass3_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF5 RID: 16117
			// (get) Token: 0x0600CAF5 RID: 51957 RVA: 0x003172CC File Offset: 0x003154CC
			// (set) Token: 0x0600CAF6 RID: 51958 RVA: 0x00062765 File Offset: 0x00060965
			public unsafe Pot pot
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_pot);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_pot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EF6 RID: 16118
			// (get) Token: 0x0600CAF7 RID: 51959 RVA: 0x003172FC File Offset: 0x003154FC
			// (set) Token: 0x0600CAF8 RID: 51960 RVA: 0x00062784 File Offset: 0x00060984
			public unsafe PotConfigurationData configData
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotConfigurationData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400897D RID: 35197
			private static readonly System.IntPtr NativeFieldInfoPtr_pot;

			// Token: 0x0400897E RID: 35198
			private static readonly System.IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x0400897F RID: 35199
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008980 RID: 35200
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000957 RID: 2391
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.PotLoader+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CAF9 RID: 51961 RVA: 0x0031732C File Offset: 0x0031552C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<PotLoader.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotLoader>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotLoader.__c__DisplayClass4_0>.NativeClassPtr);
				PotLoader.__c__DisplayClass4_0.NativeFieldInfoPtr_pot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotLoader.__c__DisplayClass4_0>.NativeClassPtr, "pot");
				PotLoader.__c__DisplayClass4_0.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotLoader.__c__DisplayClass4_0>.NativeClassPtr, "configData");
				PotLoader.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotLoader.__c__DisplayClass4_0>.NativeClassPtr, 100668905);
				PotLoader.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotLoader.__c__DisplayClass4_0>.NativeClassPtr, 100668906);
			}

			// Token: 0x0600CAFA RID: 51962 RVA: 0x003173A8 File Offset: 0x003155A8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotLoader.__c__DisplayClass4_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotLoader.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CAFB RID: 51963 RVA: 0x003173E4 File Offset: 0x003155E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135253, XrefRangeEnd = 135273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotLoader.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CAFC RID: 51964 RVA: 0x000627A3 File Offset: 0x000609A3
			public __c__DisplayClass4_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF7 RID: 16119
			// (get) Token: 0x0600CAFD RID: 51965 RVA: 0x00317418 File Offset: 0x00315618
			// (set) Token: 0x0600CAFE RID: 51966 RVA: 0x000627AC File Offset: 0x000609AC
			public unsafe Pot pot
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotLoader.__c__DisplayClass4_0.NativeFieldInfoPtr_pot);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotLoader.__c__DisplayClass4_0.NativeFieldInfoPtr_pot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EF8 RID: 16120
			// (get) Token: 0x0600CAFF RID: 51967 RVA: 0x00317448 File Offset: 0x00315648
			// (set) Token: 0x0600CB00 RID: 51968 RVA: 0x000627CB File Offset: 0x000609CB
			public unsafe PotConfigurationData configData
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotLoader.__c__DisplayClass4_0.NativeFieldInfoPtr_configData);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotConfigurationData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotLoader.__c__DisplayClass4_0.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008981 RID: 35201
			private static readonly System.IntPtr NativeFieldInfoPtr_pot;

			// Token: 0x04008982 RID: 35202
			private static readonly System.IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x04008983 RID: 35203
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008984 RID: 35204
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
