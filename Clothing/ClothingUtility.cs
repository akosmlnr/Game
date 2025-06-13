using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Clothing
{
	// Token: 0x020004BD RID: 1213
	public class ClothingUtility : Singleton<ClothingUtility>
	{
		// Token: 0x06006840 RID: 26688 RVA: 0x001D6F18 File Offset: 0x001D5118
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingUtility()
		{
			Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Clothing", "ClothingUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr);
			ClothingUtility.NativeFieldInfoPtr_ColorDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ColorDataList");
			ClothingUtility.NativeFieldInfoPtr_ClothingSlotDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ClothingSlotDataList");
			ClothingUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100676564);
			ClothingUtility.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100676565);
			ClothingUtility.NativeMethodInfoPtr_GetColorData_Public_ColorData_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100676566);
			ClothingUtility.NativeMethodInfoPtr_GetSlotData_Public_ClothingSlotData_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100676567);
			ClothingUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100676568);
		}

		// Token: 0x06006841 RID: 26689 RVA: 0x001D6FD4 File Offset: 0x001D51D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211233, XrefRangeEnd = 211288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006842 RID: 26690 RVA: 0x001D7010 File Offset: 0x001D5210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211288, XrefRangeEnd = 211385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006843 RID: 26691 RVA: 0x001D7044 File Offset: 0x001D5244
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211399, RefRangeEnd = 211402, XrefRangeStart = 211385, XrefRangeEnd = 211399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingUtility.ColorData GetColorData(EClothingColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr_GetColorData_Public_ColorData_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingUtility.ColorData>(intPtr2) : null;
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x001D7090 File Offset: 0x001D5290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211416, RefRangeEnd = 211418, XrefRangeStart = 211402, XrefRangeEnd = 211416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingUtility.ClothingSlotData GetSlotData(EClothingSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref slot;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr_GetSlotData_Public_ClothingSlotData_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingUtility.ClothingSlotData>(intPtr2) : null;
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x001D70DC File Offset: 0x001D52DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211418, XrefRangeEnd = 211435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006846 RID: 26694 RVA: 0x0003114A File Offset: 0x0002F34A
		public ClothingUtility(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x06006847 RID: 26695 RVA: 0x001D7118 File Offset: 0x001D5318
		// (set) Token: 0x06006848 RID: 26696 RVA: 0x00031153 File Offset: 0x0002F353
		public unsafe List<ClothingUtility.ColorData> ColorDataList
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ColorDataList);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClothingUtility.ColorData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ColorDataList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x06006849 RID: 26697 RVA: 0x001D7148 File Offset: 0x001D5348
		// (set) Token: 0x0600684A RID: 26698 RVA: 0x00031172 File Offset: 0x0002F372
		public unsafe List<ClothingUtility.ClothingSlotData> ClothingSlotDataList
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ClothingSlotDataList);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClothingUtility.ClothingSlotData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ClothingSlotDataList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004726 RID: 18214
		private static readonly System.IntPtr NativeFieldInfoPtr_ColorDataList;

		// Token: 0x04004727 RID: 18215
		private static readonly System.IntPtr NativeFieldInfoPtr_ClothingSlotDataList;

		// Token: 0x04004728 RID: 18216
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004729 RID: 18217
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400472A RID: 18218
		private static readonly System.IntPtr NativeMethodInfoPtr_GetColorData_Public_ColorData_EClothingColor_0;

		// Token: 0x0400472B RID: 18219
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSlotData_Public_ClothingSlotData_EClothingSlot_0;

		// Token: 0x0400472C RID: 18220
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A7E RID: 2686
		[System.Serializable]
		public class ColorData : Il2CppSystem.Object
		{
			// Token: 0x0600D4AE RID: 54446 RVA: 0x00333458 File Offset: 0x00331658
			// Note: this type is marked as 'beforefieldinit'.
			static ColorData()
			{
				Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ColorData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr);
				ClothingUtility.ColorData.NativeFieldInfoPtr_ColorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, "ColorType");
				ClothingUtility.ColorData.NativeFieldInfoPtr_ActualColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, "ActualColor");
				ClothingUtility.ColorData.NativeFieldInfoPtr_LabelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, "LabelColor");
				ClothingUtility.ColorData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, 100676569);
			}

			// Token: 0x0600D4AF RID: 54447 RVA: 0x003334D4 File Offset: 0x003316D4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.ColorData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D4B0 RID: 54448 RVA: 0x0006728A File Offset: 0x0006548A
			public ColorData(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041C9 RID: 16841
			// (get) Token: 0x0600D4B1 RID: 54449 RVA: 0x00333510 File Offset: 0x00331710
			// (set) Token: 0x0600D4B2 RID: 54450 RVA: 0x00067293 File Offset: 0x00065493
			public unsafe EClothingColor ColorType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ColorType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ColorType)) = value;
				}
			}

			// Token: 0x170041CA RID: 16842
			// (get) Token: 0x0600D4B3 RID: 54451 RVA: 0x00333538 File Offset: 0x00331738
			// (set) Token: 0x0600D4B4 RID: 54452 RVA: 0x000672AE File Offset: 0x000654AE
			public unsafe Color ActualColor
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ActualColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ActualColor)) = value;
				}
			}

			// Token: 0x170041CB RID: 16843
			// (get) Token: 0x0600D4B5 RID: 54453 RVA: 0x00333560 File Offset: 0x00331760
			// (set) Token: 0x0600D4B6 RID: 54454 RVA: 0x000672C9 File Offset: 0x000654C9
			public unsafe Color LabelColor
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_LabelColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_LabelColor)) = value;
				}
			}

			// Token: 0x04008F7E RID: 36734
			private static readonly System.IntPtr NativeFieldInfoPtr_ColorType;

			// Token: 0x04008F7F RID: 36735
			private static readonly System.IntPtr NativeFieldInfoPtr_ActualColor;

			// Token: 0x04008F80 RID: 36736
			private static readonly System.IntPtr NativeFieldInfoPtr_LabelColor;

			// Token: 0x04008F81 RID: 36737
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A7F RID: 2687
		[System.Serializable]
		public class ClothingSlotData : Il2CppSystem.Object
		{
			// Token: 0x0600D4B7 RID: 54455 RVA: 0x00333588 File Offset: 0x00331788
			// Note: this type is marked as 'beforefieldinit'.
			static ClothingSlotData()
			{
				Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ClothingSlotData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr);
				ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, "Slot");
				ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, "Name");
				ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, "Icon");
				ClothingUtility.ClothingSlotData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, 100676570);
			}

			// Token: 0x0600D4B8 RID: 54456 RVA: 0x00333604 File Offset: 0x00331804
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClothingSlotData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.ClothingSlotData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D4B9 RID: 54457 RVA: 0x000672E4 File Offset: 0x000654E4
			public ClothingSlotData(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041CC RID: 16844
			// (get) Token: 0x0600D4BA RID: 54458 RVA: 0x00333640 File Offset: 0x00331840
			// (set) Token: 0x0600D4BB RID: 54459 RVA: 0x000672ED File Offset: 0x000654ED
			public unsafe EClothingSlot Slot
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Slot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Slot)) = value;
				}
			}

			// Token: 0x170041CD RID: 16845
			// (get) Token: 0x0600D4BC RID: 54460 RVA: 0x00333668 File Offset: 0x00331868
			// (set) Token: 0x0600D4BD RID: 54461 RVA: 0x00067308 File Offset: 0x00065508
			public unsafe string Name
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041CE RID: 16846
			// (get) Token: 0x0600D4BE RID: 54462 RVA: 0x00333690 File Offset: 0x00331890
			// (set) Token: 0x0600D4BF RID: 54463 RVA: 0x00067327 File Offset: 0x00065527
			public unsafe Sprite Icon
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Icon);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F82 RID: 36738
			private static readonly System.IntPtr NativeFieldInfoPtr_Slot;

			// Token: 0x04008F83 RID: 36739
			private static readonly System.IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04008F84 RID: 36740
			private static readonly System.IntPtr NativeFieldInfoPtr_Icon;

			// Token: 0x04008F85 RID: 36741
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A80 RID: 2688
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4C0 RID: 54464 RVA: 0x003336C0 File Offset: 0x003318C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr, "color");
				ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr, 100676571);
				ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_ColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr, 100676572);
			}

			// Token: 0x0600D4C1 RID: 54465 RVA: 0x00333728 File Offset: 0x00331928
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D4C2 RID: 54466 RVA: 0x00333764 File Offset: 0x00331964
			[CallerCount(0)]
			public unsafe bool _Awake_b__0(ClothingUtility.ColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_ColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D4C3 RID: 54467 RVA: 0x00067346 File Offset: 0x00065546
			public __c__DisplayClass4_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041CF RID: 16847
			// (get) Token: 0x0600D4C4 RID: 54468 RVA: 0x003337B4 File Offset: 0x003319B4
			// (set) Token: 0x0600D4C5 RID: 54469 RVA: 0x0006734F File Offset: 0x0006554F
			public unsafe EClothingColor color
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04008F86 RID: 36742
			private static readonly System.IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008F87 RID: 36743
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F88 RID: 36744
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_ColorData_0;
		}

		// Token: 0x02000A81 RID: 2689
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4C6 RID: 54470 RVA: 0x003337DC File Offset: 0x003319DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr, "color");
				ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr, 100676573);
				ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__OnValidate_b__0_Internal_Boolean_ColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr, 100676574);
			}

			// Token: 0x0600D4C7 RID: 54471 RVA: 0x00333844 File Offset: 0x00331A44
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D4C8 RID: 54472 RVA: 0x00333880 File Offset: 0x00331A80
			[CallerCount(0)]
			public unsafe bool _OnValidate_b__0(ClothingUtility.ColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__OnValidate_b__0_Internal_Boolean_ColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D4C9 RID: 54473 RVA: 0x0006736A File Offset: 0x0006556A
			public __c__DisplayClass5_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041D0 RID: 16848
			// (get) Token: 0x0600D4CA RID: 54474 RVA: 0x003338D0 File Offset: 0x00331AD0
			// (set) Token: 0x0600D4CB RID: 54475 RVA: 0x00067373 File Offset: 0x00065573
			public unsafe EClothingColor color
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04008F89 RID: 36745
			private static readonly System.IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008F8A RID: 36746
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F8B RID: 36747
			private static readonly System.IntPtr NativeMethodInfoPtr__OnValidate_b__0_Internal_Boolean_ColorData_0;
		}

		// Token: 0x02000A82 RID: 2690
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass5_1")]
		public sealed class __c__DisplayClass5_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D4CC RID: 54476 RVA: 0x003338F8 File Offset: 0x00331AF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_1()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass5_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass5_1.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr, "slot");
				ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr, 100676575);
				ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__OnValidate_b__1_Internal_Boolean_ClothingSlotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr, 100676576);
			}

			// Token: 0x0600D4CD RID: 54477 RVA: 0x00333960 File Offset: 0x00331B60
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D4CE RID: 54478 RVA: 0x0033399C File Offset: 0x00331B9C
			[CallerCount(0)]
			public unsafe bool _OnValidate_b__1(ClothingUtility.ClothingSlotData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__OnValidate_b__1_Internal_Boolean_ClothingSlotData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D4CF RID: 54479 RVA: 0x0006738E File Offset: 0x0006558E
			public __c__DisplayClass5_1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041D1 RID: 16849
			// (get) Token: 0x0600D4D0 RID: 54480 RVA: 0x003339EC File Offset: 0x00331BEC
			// (set) Token: 0x0600D4D1 RID: 54481 RVA: 0x00067397 File Offset: 0x00065597
			public unsafe EClothingSlot slot
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_1.NativeFieldInfoPtr_slot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_1.NativeFieldInfoPtr_slot)) = value;
				}
			}

			// Token: 0x04008F8C RID: 36748
			private static readonly System.IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x04008F8D RID: 36749
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F8E RID: 36750
			private static readonly System.IntPtr NativeMethodInfoPtr__OnValidate_b__1_Internal_Boolean_ClothingSlotData_0;
		}

		// Token: 0x02000A83 RID: 2691
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4D2 RID: 54482 RVA: 0x00333A14 File Offset: 0x00331C14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass6_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr, "color");
				ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr, 100676577);
				ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__GetColorData_b__0_Internal_Boolean_ColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr, 100676578);
			}

			// Token: 0x0600D4D3 RID: 54483 RVA: 0x00333A7C File Offset: 0x00331C7C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D4D4 RID: 54484 RVA: 0x00333AB8 File Offset: 0x00331CB8
			[CallerCount(0)]
			public unsafe bool _GetColorData_b__0(ClothingUtility.ColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__GetColorData_b__0_Internal_Boolean_ColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D4D5 RID: 54485 RVA: 0x000673B2 File Offset: 0x000655B2
			public __c__DisplayClass6_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041D2 RID: 16850
			// (get) Token: 0x0600D4D6 RID: 54486 RVA: 0x00333B08 File Offset: 0x00331D08
			// (set) Token: 0x0600D4D7 RID: 54487 RVA: 0x000673BB File Offset: 0x000655BB
			public unsafe EClothingColor color
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass6_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass6_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04008F8F RID: 36751
			private static readonly System.IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008F90 RID: 36752
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F91 RID: 36753
			private static readonly System.IntPtr NativeMethodInfoPtr__GetColorData_b__0_Internal_Boolean_ColorData_0;
		}

		// Token: 0x02000A84 RID: 2692
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4D8 RID: 54488 RVA: 0x00333B30 File Offset: 0x00331D30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass7_0.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr, "slot");
				ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr, 100676579);
				ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__GetSlotData_b__0_Internal_Boolean_ClothingSlotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr, 100676580);
			}

			// Token: 0x0600D4D9 RID: 54489 RVA: 0x00333B98 File Offset: 0x00331D98
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D4DA RID: 54490 RVA: 0x00333BD4 File Offset: 0x00331DD4
			[CallerCount(0)]
			public unsafe bool _GetSlotData_b__0(ClothingUtility.ClothingSlotData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__GetSlotData_b__0_Internal_Boolean_ClothingSlotData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D4DB RID: 54491 RVA: 0x000673D6 File Offset: 0x000655D6
			public __c__DisplayClass7_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041D3 RID: 16851
			// (get) Token: 0x0600D4DC RID: 54492 RVA: 0x00333C24 File Offset: 0x00331E24
			// (set) Token: 0x0600D4DD RID: 54493 RVA: 0x000673DF File Offset: 0x000655DF
			public unsafe EClothingSlot slot
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass7_0.NativeFieldInfoPtr_slot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass7_0.NativeFieldInfoPtr_slot)) = value;
				}
			}

			// Token: 0x04008F92 RID: 36754
			private static readonly System.IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x04008F93 RID: 36755
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F94 RID: 36756
			private static readonly System.IntPtr NativeMethodInfoPtr__GetSlotData_b__0_Internal_Boolean_ClothingSlotData_0;
		}
	}
}
