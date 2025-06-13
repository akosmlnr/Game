using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000680 RID: 1664
	public class PlayerEnergyUI : Singleton<PlayerEnergyUI>
	{
		// Token: 0x06009384 RID: 37764 RVA: 0x002644C4 File Offset: 0x002626C4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerEnergyUI()
		{
			Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PlayerEnergyUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr);
			PlayerEnergyUI.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "Slider");
			PlayerEnergyUI.NativeFieldInfoPtr_SliderRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "SliderRect");
			PlayerEnergyUI.NativeFieldInfoPtr_FillImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "FillImage");
			PlayerEnergyUI.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "Label");
			PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "SliderColor_Green");
			PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "SliderColor_Red");
			PlayerEnergyUI.NativeFieldInfoPtr_displayedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "displayedValue");
			PlayerEnergyUI.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681671);
			PlayerEnergyUI.NativeMethodInfoPtr_UpdateDisplayedEnergy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681672);
			PlayerEnergyUI.NativeMethodInfoPtr_SetDisplayedEnergy_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681673);
			PlayerEnergyUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681674);
			PlayerEnergyUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681675);
			PlayerEnergyUI.NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681676);
		}

		// Token: 0x06009385 RID: 37765 RVA: 0x002645F8 File Offset: 0x002627F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266624, XrefRangeEnd = 266647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEnergyUI.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009386 RID: 37766 RVA: 0x00264634 File Offset: 0x00262834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266647, XrefRangeEnd = 266652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisplayedEnergy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergyUI.NativeMethodInfoPtr_UpdateDisplayedEnergy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009387 RID: 37767 RVA: 0x00264668 File Offset: 0x00262868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266652, XrefRangeEnd = 266653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedEnergy(float energy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref energy;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergyUI.NativeMethodInfoPtr_SetDisplayedEnergy_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009388 RID: 37768 RVA: 0x002646A8 File Offset: 0x002628A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266653, XrefRangeEnd = 266656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEnergyUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009389 RID: 37769 RVA: 0x002646E4 File Offset: 0x002628E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266656, XrefRangeEnd = 266659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEnergyUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergyUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600938A RID: 37770 RVA: 0x00264720 File Offset: 0x00262920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266659, XrefRangeEnd = 266676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__7_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergyUI.NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600938B RID: 37771 RVA: 0x00047064 File Offset: 0x00045264
		public PlayerEnergyUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CFC RID: 11516
		// (get) Token: 0x0600938C RID: 37772 RVA: 0x00264754 File Offset: 0x00262954
		// (set) Token: 0x0600938D RID: 37773 RVA: 0x0004706D File Offset: 0x0004526D
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CFD RID: 11517
		// (get) Token: 0x0600938E RID: 37774 RVA: 0x00264784 File Offset: 0x00262984
		// (set) Token: 0x0600938F RID: 37775 RVA: 0x0004708C File Offset: 0x0004528C
		public unsafe RectTransform SliderRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CFE RID: 11518
		// (get) Token: 0x06009390 RID: 37776 RVA: 0x002647B4 File Offset: 0x002629B4
		// (set) Token: 0x06009391 RID: 37777 RVA: 0x000470AB File Offset: 0x000452AB
		public unsafe Image FillImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_FillImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_FillImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CFF RID: 11519
		// (get) Token: 0x06009392 RID: 37778 RVA: 0x002647E4 File Offset: 0x002629E4
		// (set) Token: 0x06009393 RID: 37779 RVA: 0x000470CA File Offset: 0x000452CA
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D00 RID: 11520
		// (get) Token: 0x06009394 RID: 37780 RVA: 0x00264814 File Offset: 0x00262A14
		// (set) Token: 0x06009395 RID: 37781 RVA: 0x000470E9 File Offset: 0x000452E9
		public unsafe Color SliderColor_Green
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Green);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Green)) = value;
			}
		}

		// Token: 0x17002D01 RID: 11521
		// (get) Token: 0x06009396 RID: 37782 RVA: 0x0026483C File Offset: 0x00262A3C
		// (set) Token: 0x06009397 RID: 37783 RVA: 0x00047104 File Offset: 0x00045304
		public unsafe Color SliderColor_Red
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Red);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Red)) = value;
			}
		}

		// Token: 0x17002D02 RID: 11522
		// (get) Token: 0x06009398 RID: 37784 RVA: 0x00264864 File Offset: 0x00262A64
		// (set) Token: 0x06009399 RID: 37785 RVA: 0x0004711F File Offset: 0x0004531F
		public unsafe float displayedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_displayedValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_displayedValue)) = value;
			}
		}

		// Token: 0x040063BD RID: 25533
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x040063BE RID: 25534
		private static readonly IntPtr NativeFieldInfoPtr_SliderRect;

		// Token: 0x040063BF RID: 25535
		private static readonly IntPtr NativeFieldInfoPtr_FillImage;

		// Token: 0x040063C0 RID: 25536
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x040063C1 RID: 25537
		private static readonly IntPtr NativeFieldInfoPtr_SliderColor_Green;

		// Token: 0x040063C2 RID: 25538
		private static readonly IntPtr NativeFieldInfoPtr_SliderColor_Red;

		// Token: 0x040063C3 RID: 25539
		private static readonly IntPtr NativeFieldInfoPtr_displayedValue;

		// Token: 0x040063C4 RID: 25540
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040063C5 RID: 25541
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplayedEnergy_Private_Void_0;

		// Token: 0x040063C6 RID: 25542
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedEnergy_Public_Void_Single_0;

		// Token: 0x040063C7 RID: 25543
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040063C8 RID: 25544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040063C9 RID: 25545
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0;
	}
}
