using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.UI.Tooltips;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020006D1 RID: 1745
	public class DeliveryStatusDisplay : MonoBehaviour
	{
		// Token: 0x06009BC8 RID: 39880 RVA: 0x0027D37C File Offset: 0x0027B57C
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryStatusDisplay()
		{
			Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "DeliveryStatusDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr);
			DeliveryStatusDisplay.NativeFieldInfoPtr__DeliveryInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "<DeliveryInstance>k__BackingField");
			DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "ItemEntryPrefab");
			DeliveryStatusDisplay.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "Rect");
			DeliveryStatusDisplay.NativeFieldInfoPtr_DestinationLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "DestinationLabel");
			DeliveryStatusDisplay.NativeFieldInfoPtr_ShopLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "ShopLabel");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusImage");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusLabel");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusTooltip");
			DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "ItemEntryContainer");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Transit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusColor_Transit");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Waiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusColor_Waiting");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Arrived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusColor_Arrived");
			DeliveryStatusDisplay.NativeMethodInfoPtr_get_DeliveryInstance_Public_get_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100682620);
			DeliveryStatusDisplay.NativeMethodInfoPtr_set_DeliveryInstance_Private_set_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100682621);
			DeliveryStatusDisplay.NativeMethodInfoPtr_AssignDelivery_Public_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100682622);
			DeliveryStatusDisplay.NativeMethodInfoPtr_RefreshStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100682623);
			DeliveryStatusDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100682624);
		}

		// Token: 0x17002FB5 RID: 12213
		// (get) Token: 0x06009BC9 RID: 39881 RVA: 0x0027D500 File Offset: 0x0027B700
		// (set) Token: 0x06009BCA RID: 39882 RVA: 0x0027D540 File Offset: 0x0027B740
		public unsafe DeliveryInstance DeliveryInstance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_get_DeliveryInstance_Public_get_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_set_DeliveryInstance_Private_set_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009BCB RID: 39883 RVA: 0x0027D584 File Offset: 0x0027B784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278019, RefRangeEnd = 278021, XrefRangeStart = 277983, XrefRangeEnd = 278019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignDelivery(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_AssignDelivery_Public_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009BCC RID: 39884 RVA: 0x0027D5C8 File Offset: 0x0027B7C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 278033, RefRangeEnd = 278036, XrefRangeStart = 278021, XrefRangeEnd = 278033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_RefreshStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009BCD RID: 39885 RVA: 0x0027D5FC File Offset: 0x0027B7FC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryStatusDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009BCE RID: 39886 RVA: 0x0004BB7A File Offset: 0x00049D7A
		public DeliveryStatusDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FA9 RID: 12201
		// (get) Token: 0x06009BCF RID: 39887 RVA: 0x0027D638 File Offset: 0x0027B838
		// (set) Token: 0x06009BD0 RID: 39888 RVA: 0x0004BB83 File Offset: 0x00049D83
		public unsafe DeliveryInstance _DeliveryInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__DeliveryInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__DeliveryInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAA RID: 12202
		// (get) Token: 0x06009BD1 RID: 39889 RVA: 0x0027D668 File Offset: 0x0027B868
		// (set) Token: 0x06009BD2 RID: 39890 RVA: 0x0004BBA2 File Offset: 0x00049DA2
		public unsafe GameObject ItemEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAB RID: 12203
		// (get) Token: 0x06009BD3 RID: 39891 RVA: 0x0027D698 File Offset: 0x0027B898
		// (set) Token: 0x06009BD4 RID: 39892 RVA: 0x0004BBC1 File Offset: 0x00049DC1
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAC RID: 12204
		// (get) Token: 0x06009BD5 RID: 39893 RVA: 0x0027D6C8 File Offset: 0x0027B8C8
		// (set) Token: 0x06009BD6 RID: 39894 RVA: 0x0004BBE0 File Offset: 0x00049DE0
		public unsafe Text DestinationLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_DestinationLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_DestinationLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAD RID: 12205
		// (get) Token: 0x06009BD7 RID: 39895 RVA: 0x0027D6F8 File Offset: 0x0027B8F8
		// (set) Token: 0x06009BD8 RID: 39896 RVA: 0x0004BBFF File Offset: 0x00049DFF
		public unsafe Text ShopLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ShopLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ShopLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAE RID: 12206
		// (get) Token: 0x06009BD9 RID: 39897 RVA: 0x0027D728 File Offset: 0x0027B928
		// (set) Token: 0x06009BDA RID: 39898 RVA: 0x0004BC1E File Offset: 0x00049E1E
		public unsafe Image StatusImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAF RID: 12207
		// (get) Token: 0x06009BDB RID: 39899 RVA: 0x0027D758 File Offset: 0x0027B958
		// (set) Token: 0x06009BDC RID: 39900 RVA: 0x0004BC3D File Offset: 0x00049E3D
		public unsafe Text StatusLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB0 RID: 12208
		// (get) Token: 0x06009BDD RID: 39901 RVA: 0x0027D788 File Offset: 0x0027B988
		// (set) Token: 0x06009BDE RID: 39902 RVA: 0x0004BC5C File Offset: 0x00049E5C
		public unsafe Tooltip StatusTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB1 RID: 12209
		// (get) Token: 0x06009BDF RID: 39903 RVA: 0x0027D7B8 File Offset: 0x0027B9B8
		// (set) Token: 0x06009BE0 RID: 39904 RVA: 0x0004BC7B File Offset: 0x00049E7B
		public unsafe RectTransform ItemEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB2 RID: 12210
		// (get) Token: 0x06009BE1 RID: 39905 RVA: 0x0027D7E8 File Offset: 0x0027B9E8
		// (set) Token: 0x06009BE2 RID: 39906 RVA: 0x0004BC9A File Offset: 0x00049E9A
		public unsafe Color StatusColor_Transit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Transit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Transit)) = value;
			}
		}

		// Token: 0x17002FB3 RID: 12211
		// (get) Token: 0x06009BE3 RID: 39907 RVA: 0x0027D810 File Offset: 0x0027BA10
		// (set) Token: 0x06009BE4 RID: 39908 RVA: 0x0004BCB5 File Offset: 0x00049EB5
		public unsafe Color StatusColor_Waiting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Waiting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Waiting)) = value;
			}
		}

		// Token: 0x17002FB4 RID: 12212
		// (get) Token: 0x06009BE5 RID: 39909 RVA: 0x0027D838 File Offset: 0x0027BA38
		// (set) Token: 0x06009BE6 RID: 39910 RVA: 0x0004BCD0 File Offset: 0x00049ED0
		public unsafe Color StatusColor_Arrived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Arrived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Arrived)) = value;
			}
		}

		// Token: 0x040068E8 RID: 26856
		private static readonly IntPtr NativeFieldInfoPtr__DeliveryInstance_k__BackingField;

		// Token: 0x040068E9 RID: 26857
		private static readonly IntPtr NativeFieldInfoPtr_ItemEntryPrefab;

		// Token: 0x040068EA RID: 26858
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040068EB RID: 26859
		private static readonly IntPtr NativeFieldInfoPtr_DestinationLabel;

		// Token: 0x040068EC RID: 26860
		private static readonly IntPtr NativeFieldInfoPtr_ShopLabel;

		// Token: 0x040068ED RID: 26861
		private static readonly IntPtr NativeFieldInfoPtr_StatusImage;

		// Token: 0x040068EE RID: 26862
		private static readonly IntPtr NativeFieldInfoPtr_StatusLabel;

		// Token: 0x040068EF RID: 26863
		private static readonly IntPtr NativeFieldInfoPtr_StatusTooltip;

		// Token: 0x040068F0 RID: 26864
		private static readonly IntPtr NativeFieldInfoPtr_ItemEntryContainer;

		// Token: 0x040068F1 RID: 26865
		private static readonly IntPtr NativeFieldInfoPtr_StatusColor_Transit;

		// Token: 0x040068F2 RID: 26866
		private static readonly IntPtr NativeFieldInfoPtr_StatusColor_Waiting;

		// Token: 0x040068F3 RID: 26867
		private static readonly IntPtr NativeFieldInfoPtr_StatusColor_Arrived;

		// Token: 0x040068F4 RID: 26868
		private static readonly IntPtr NativeMethodInfoPtr_get_DeliveryInstance_Public_get_DeliveryInstance_0;

		// Token: 0x040068F5 RID: 26869
		private static readonly IntPtr NativeMethodInfoPtr_set_DeliveryInstance_Private_set_Void_DeliveryInstance_0;

		// Token: 0x040068F6 RID: 26870
		private static readonly IntPtr NativeMethodInfoPtr_AssignDelivery_Public_Void_DeliveryInstance_0;

		// Token: 0x040068F7 RID: 26871
		private static readonly IntPtr NativeMethodInfoPtr_RefreshStatus_Public_Void_0;

		// Token: 0x040068F8 RID: 26872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
