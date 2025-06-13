using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200068A RID: 1674
	public class RegionUnlockedCanvas : Singleton<RegionUnlockedCanvas>
	{
		// Token: 0x06009496 RID: 38038 RVA: 0x002679E0 File Offset: 0x00265BE0
		// Note: this type is marked as 'beforefieldinit'.
		static RegionUnlockedCanvas()
		{
			Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "RegionUnlockedCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr);
			RegionUnlockedCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "<IsRunning>k__BackingField");
			RegionUnlockedCanvas.NativeFieldInfoPtr__Order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "<Order>k__BackingField");
			RegionUnlockedCanvas.NativeFieldInfoPtr_OpenCloseAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "OpenCloseAnim");
			RegionUnlockedCanvas.NativeFieldInfoPtr_RegionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "RegionLabel");
			RegionUnlockedCanvas.NativeFieldInfoPtr_RegionDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "RegionDescription");
			RegionUnlockedCanvas.NativeFieldInfoPtr_RegionImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "RegionImage");
			RegionUnlockedCanvas.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "region");
			RegionUnlockedCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681840);
			RegionUnlockedCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681841);
			RegionUnlockedCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681842);
			RegionUnlockedCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681843);
			RegionUnlockedCanvas.NativeMethodInfoPtr_QueueUnlocked_Public_Void_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681844);
			RegionUnlockedCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681845);
			RegionUnlockedCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681846);
			RegionUnlockedCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681847);
		}

		// Token: 0x17002D58 RID: 11608
		// (get) Token: 0x06009497 RID: 38039 RVA: 0x00267B3C File Offset: 0x00265D3C
		// (set) Token: 0x06009498 RID: 38040 RVA: 0x00267B78 File Offset: 0x00265D78
		public unsafe virtual bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002D59 RID: 11609
		// (get) Token: 0x06009499 RID: 38041 RVA: 0x00267BB8 File Offset: 0x00265DB8
		// (set) Token: 0x0600949A RID: 38042 RVA: 0x00267BF4 File Offset: 0x00265DF4
		public unsafe virtual int Order
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 84444, RefRangeEnd = 84470, XrefRangeStart = 84444, XrefRangeEnd = 84470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 183194, RefRangeEnd = 183195, XrefRangeStart = 183194, XrefRangeEnd = 183195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600949B RID: 38043 RVA: 0x00267C34 File Offset: 0x00265E34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268377, RefRangeEnd = 268378, XrefRangeStart = 268371, XrefRangeEnd = 268377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueUnlocked(EMapRegion _region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _region;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_QueueUnlocked_Public_Void_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600949C RID: 38044 RVA: 0x00267C74 File Offset: 0x00265E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268378, XrefRangeEnd = 268466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600949D RID: 38045 RVA: 0x00267CA8 File Offset: 0x00265EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268466, XrefRangeEnd = 268469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600949E RID: 38046 RVA: 0x00267CDC File Offset: 0x00265EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268469, XrefRangeEnd = 268472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegionUnlockedCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600949F RID: 38047 RVA: 0x000479CC File Offset: 0x00045BCC
		public RegionUnlockedCanvas(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D51 RID: 11601
		// (get) Token: 0x060094A0 RID: 38048 RVA: 0x00267D18 File Offset: 0x00265F18
		// (set) Token: 0x060094A1 RID: 38049 RVA: 0x000479D5 File Offset: 0x00045BD5
		public unsafe bool _IsRunning_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D52 RID: 11602
		// (get) Token: 0x060094A2 RID: 38050 RVA: 0x00267D40 File Offset: 0x00265F40
		// (set) Token: 0x060094A3 RID: 38051 RVA: 0x000479F0 File Offset: 0x00045BF0
		public unsafe int _Order_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__Order_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__Order_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D53 RID: 11603
		// (get) Token: 0x060094A4 RID: 38052 RVA: 0x00267D68 File Offset: 0x00265F68
		// (set) Token: 0x060094A5 RID: 38053 RVA: 0x00047A0B File Offset: 0x00045C0B
		public unsafe Animation OpenCloseAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_OpenCloseAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_OpenCloseAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D54 RID: 11604
		// (get) Token: 0x060094A6 RID: 38054 RVA: 0x00267D98 File Offset: 0x00265F98
		// (set) Token: 0x060094A7 RID: 38055 RVA: 0x00047A2A File Offset: 0x00045C2A
		public unsafe TextMeshProUGUI RegionLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D55 RID: 11605
		// (get) Token: 0x060094A8 RID: 38056 RVA: 0x00267DC8 File Offset: 0x00265FC8
		// (set) Token: 0x060094A9 RID: 38057 RVA: 0x00047A49 File Offset: 0x00045C49
		public unsafe TextMeshProUGUI RegionDescription
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionDescription);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D56 RID: 11606
		// (get) Token: 0x060094AA RID: 38058 RVA: 0x00267DF8 File Offset: 0x00265FF8
		// (set) Token: 0x060094AB RID: 38059 RVA: 0x00047A68 File Offset: 0x00045C68
		public unsafe Image RegionImage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionImage);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D57 RID: 11607
		// (get) Token: 0x060094AC RID: 38060 RVA: 0x00267E28 File Offset: 0x00266028
		// (set) Token: 0x060094AD RID: 38061 RVA: 0x00047A87 File Offset: 0x00045C87
		public unsafe EMapRegion region
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_region);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_region)) = value;
			}
		}

		// Token: 0x0400646D RID: 25709
		private static readonly System.IntPtr NativeFieldInfoPtr__IsRunning_k__BackingField;

		// Token: 0x0400646E RID: 25710
		private static readonly System.IntPtr NativeFieldInfoPtr__Order_k__BackingField;

		// Token: 0x0400646F RID: 25711
		private static readonly System.IntPtr NativeFieldInfoPtr_OpenCloseAnim;

		// Token: 0x04006470 RID: 25712
		private static readonly System.IntPtr NativeFieldInfoPtr_RegionLabel;

		// Token: 0x04006471 RID: 25713
		private static readonly System.IntPtr NativeFieldInfoPtr_RegionDescription;

		// Token: 0x04006472 RID: 25714
		private static readonly System.IntPtr NativeFieldInfoPtr_RegionImage;

		// Token: 0x04006473 RID: 25715
		private static readonly System.IntPtr NativeFieldInfoPtr_region;

		// Token: 0x04006474 RID: 25716
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006475 RID: 25717
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0;

		// Token: 0x04006476 RID: 25718
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04006477 RID: 25719
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0;

		// Token: 0x04006478 RID: 25720
		private static readonly System.IntPtr NativeMethodInfoPtr_QueueUnlocked_Public_Void_EMapRegion_0;

		// Token: 0x04006479 RID: 25721
		private static readonly System.IntPtr NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400647A RID: 25722
		private static readonly System.IntPtr NativeMethodInfoPtr_EndEvent_Public_Void_0;

		// Token: 0x0400647B RID: 25723
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B9D RID: 2973
		[ObfuscatedName("ScheduleOne.UI.RegionUnlockedCanvas+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DEB7 RID: 57015 RVA: 0x0034F934 File Offset: 0x0034DB34
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr);
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9");
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9__14_0");
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9__14_1");
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9__14_2");
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100681849);
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100681850);
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_1_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100681851);
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_2_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100681852);
			}

			// Token: 0x0600DEB8 RID: 57016 RVA: 0x0034FA00 File Offset: 0x0034DC00
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DEB9 RID: 57017 RVA: 0x0034FA3C File Offset: 0x0034DC3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268359, XrefRangeEnd = 268367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartEvent_b__14_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DEBA RID: 57018 RVA: 0x0034FA8C File Offset: 0x0034DC8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268367, XrefRangeEnd = 268369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartEvent_b__14_1(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_1_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DEBB RID: 57019 RVA: 0x0034FADC File Offset: 0x0034DCDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268369, XrefRangeEnd = 268371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartEvent_b__14_2(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_2_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DEBC RID: 57020 RVA: 0x0006C286 File Offset: 0x0006A486
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044CB RID: 17611
			// (get) Token: 0x0600DEBD RID: 57021 RVA: 0x0034FB2C File Offset: 0x0034DD2C
			// (set) Token: 0x0600DEBE RID: 57022 RVA: 0x0006C28F File Offset: 0x0006A48F
			public unsafe static RegionUnlockedCanvas.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegionUnlockedCanvas.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044CC RID: 17612
			// (get) Token: 0x0600DEBF RID: 57023 RVA: 0x0034FB54 File Offset: 0x0034DD54
			// (set) Token: 0x0600DEC0 RID: 57024 RVA: 0x0006C2A1 File Offset: 0x0006A4A1
			public unsafe static Il2CppSystem.Func<NPC, bool> __9__14_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044CD RID: 17613
			// (get) Token: 0x0600DEC1 RID: 57025 RVA: 0x0034FB7C File Offset: 0x0034DD7C
			// (set) Token: 0x0600DEC2 RID: 57026 RVA: 0x0006C2B3 File Offset: 0x0006A4B3
			public unsafe static Il2CppSystem.Func<NPC, bool> __9__14_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044CE RID: 17614
			// (get) Token: 0x0600DEC3 RID: 57027 RVA: 0x0034FBA4 File Offset: 0x0034DDA4
			// (set) Token: 0x0600DEC4 RID: 57028 RVA: 0x0006C2C5 File Offset: 0x0006A4C5
			public unsafe static Il2CppSystem.Func<NPC, bool> __9__14_2
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095AC RID: 38316
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040095AD RID: 38317
			private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x040095AE RID: 38318
			private static readonly System.IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x040095AF RID: 38319
			private static readonly System.IntPtr NativeFieldInfoPtr___9__14_2;

			// Token: 0x040095B0 RID: 38320
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095B1 RID: 38321
			private static readonly System.IntPtr NativeMethodInfoPtr__StartEvent_b__14_0_Internal_Boolean_NPC_0;

			// Token: 0x040095B2 RID: 38322
			private static readonly System.IntPtr NativeMethodInfoPtr__StartEvent_b__14_1_Internal_Boolean_NPC_0;

			// Token: 0x040095B3 RID: 38323
			private static readonly System.IntPtr NativeMethodInfoPtr__StartEvent_b__14_2_Internal_Boolean_NPC_0;
		}
	}
}
