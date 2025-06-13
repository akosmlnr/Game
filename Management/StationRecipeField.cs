using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003BA RID: 954
	public class StationRecipeField : ConfigField
	{
		// Token: 0x060049C4 RID: 18884 RVA: 0x00169F28 File Offset: 0x00168128
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeField()
		{
			Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "StationRecipeField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr);
			StationRecipeField.NativeFieldInfoPtr__SelectedRecipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "<SelectedRecipe>k__BackingField");
			StationRecipeField.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "Options");
			StationRecipeField.NativeFieldInfoPtr_onRecipeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "onRecipeChanged");
			StationRecipeField.NativeMethodInfoPtr_get_SelectedRecipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672492);
			StationRecipeField.NativeMethodInfoPtr_set_SelectedRecipe_Protected_set_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672493);
			StationRecipeField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672494);
			StationRecipeField.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672495);
			StationRecipeField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672496);
			StationRecipeField.NativeMethodInfoPtr_GetData_Public_StationRecipeFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672497);
			StationRecipeField.NativeMethodInfoPtr_Load_Public_Void_StationRecipeFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672498);
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x060049C5 RID: 18885 RVA: 0x0016A020 File Offset: 0x00168220
		// (set) Token: 0x060049C6 RID: 18886 RVA: 0x0016A060 File Offset: 0x00168260
		public unsafe StationRecipe SelectedRecipe
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_get_SelectedRecipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_set_SelectedRecipe_Protected_set_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x0016A0A4 File Offset: 0x001682A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166658, RefRangeEnd = 166659, XrefRangeStart = 166643, XrefRangeEnd = 166658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x0016A0F0 File Offset: 0x001682F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 166664, RefRangeEnd = 166668, XrefRangeStart = 166659, XrefRangeEnd = 166664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRecipe(StationRecipe recipe, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x0016A140 File Offset: 0x00168340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166668, XrefRangeEnd = 166672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationRecipeField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x0016A188 File Offset: 0x00168388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166684, RefRangeEnd = 166685, XrefRangeStart = 166672, XrefRangeEnd = 166684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_GetData_Public_StationRecipeFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldData>(intPtr2) : null;
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x0016A1C8 File Offset: 0x001683C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166701, RefRangeEnd = 166703, XrefRangeStart = 166685, XrefRangeEnd = 166701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(StationRecipeFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_Load_Public_Void_StationRecipeFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x000237A6 File Offset: 0x000219A6
		public StationRecipeField(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x060049CD RID: 18893 RVA: 0x0016A20C File Offset: 0x0016840C
		// (set) Token: 0x060049CE RID: 18894 RVA: 0x000237AF File Offset: 0x000219AF
		public unsafe StationRecipe _SelectedRecipe_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr__SelectedRecipe_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr__SelectedRecipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x060049CF RID: 18895 RVA: 0x0016A23C File Offset: 0x0016843C
		// (set) Token: 0x060049D0 RID: 18896 RVA: 0x000237CE File Offset: 0x000219CE
		public unsafe List<StationRecipe> Options
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_Options);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x060049D1 RID: 18897 RVA: 0x0016A26C File Offset: 0x0016846C
		// (set) Token: 0x060049D2 RID: 18898 RVA: 0x000237ED File Offset: 0x000219ED
		public unsafe UnityEvent<StationRecipe> onRecipeChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_onRecipeChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_onRecipeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031B0 RID: 12720
		private static readonly System.IntPtr NativeFieldInfoPtr__SelectedRecipe_k__BackingField;

		// Token: 0x040031B1 RID: 12721
		private static readonly System.IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x040031B2 RID: 12722
		private static readonly System.IntPtr NativeFieldInfoPtr_onRecipeChanged;

		// Token: 0x040031B3 RID: 12723
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SelectedRecipe_Public_get_StationRecipe_0;

		// Token: 0x040031B4 RID: 12724
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SelectedRecipe_Protected_set_Void_StationRecipe_0;

		// Token: 0x040031B5 RID: 12725
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040031B6 RID: 12726
		private static readonly System.IntPtr NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_Boolean_0;

		// Token: 0x040031B7 RID: 12727
		private static readonly System.IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040031B8 RID: 12728
		private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_StationRecipeFieldData_0;

		// Token: 0x040031B9 RID: 12729
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_StationRecipeFieldData_0;

		// Token: 0x020009C2 RID: 2498
		[ObfuscatedName("ScheduleOne.Management.StationRecipeField+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CED4 RID: 52948 RVA: 0x00322C5C File Offset: 0x00320E5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr);
				StationRecipeField.__c__DisplayClass10_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr, "data");
				StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr, 100672499);
				StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr, 100672500);
			}

			// Token: 0x0600CED5 RID: 52949 RVA: 0x00322CC4 File Offset: 0x00320EC4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CED6 RID: 52950 RVA: 0x00322D00 File Offset: 0x00320F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166640, XrefRangeEnd = 166643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(StationRecipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CED7 RID: 52951 RVA: 0x00064425 File Offset: 0x00062625
			public __c__DisplayClass10_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700402A RID: 16426
			// (get) Token: 0x0600CED8 RID: 52952 RVA: 0x00322D50 File Offset: 0x00320F50
			// (set) Token: 0x0600CED9 RID: 52953 RVA: 0x0006442E File Offset: 0x0006262E
			public unsafe StationRecipeFieldData data
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.__c__DisplayClass10_0.NativeFieldInfoPtr_data);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.__c__DisplayClass10_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BFE RID: 35838
			private static readonly System.IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04008BFF RID: 35839
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C00 RID: 35840
			private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_StationRecipe_0;
		}
	}
}
