using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.UI.Items;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000669 RID: 1641
	public class ItemSlotUI : MonoBehaviour
	{
		// Token: 0x0600904F RID: 36943 RVA: 0x0025B024 File Offset: 0x00259224
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlotUI()
		{
			Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ItemSlotUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr);
			ItemSlotUI.NativeFieldInfoPtr_normalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "normalColor");
			ItemSlotUI.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "highlightColor");
			ItemSlotUI.NativeFieldInfoPtr__assignedSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "<assignedSlot>k__BackingField");
			ItemSlotUI.NativeFieldInfoPtr_IsBeingDragged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "IsBeingDragged");
			ItemSlotUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "Rect");
			ItemSlotUI.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "Background");
			ItemSlotUI.NativeFieldInfoPtr_LockContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "LockContainer");
			ItemSlotUI.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "ItemContainer");
			ItemSlotUI.NativeFieldInfoPtr_FilterButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "FilterButton");
			ItemSlotUI.NativeFieldInfoPtr__ItemUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "<ItemUI>k__BackingField");
			ItemSlotUI.NativeMethodInfoPtr_get_assignedSlot_Public_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681313);
			ItemSlotUI.NativeMethodInfoPtr_set_assignedSlot_Protected_set_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681314);
			ItemSlotUI.NativeMethodInfoPtr_get_ItemUI_Public_get_ItemUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681315);
			ItemSlotUI.NativeMethodInfoPtr_set_ItemUI_Protected_set_Void_ItemUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681316);
			ItemSlotUI.NativeMethodInfoPtr_AssignSlot_Public_Virtual_New_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681317);
			ItemSlotUI.NativeMethodInfoPtr_ClearSlot_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681318);
			ItemSlotUI.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681319);
			ItemSlotUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681320);
			ItemSlotUI.NativeMethodInfoPtr_SetHighlighted_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681321);
			ItemSlotUI.NativeMethodInfoPtr_SetNormalColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681322);
			ItemSlotUI.NativeMethodInfoPtr_SetHighlightColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681323);
			ItemSlotUI.NativeMethodInfoPtr_Lock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681324);
			ItemSlotUI.NativeMethodInfoPtr_Unlock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681325);
			ItemSlotUI.NativeMethodInfoPtr_SetLockVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681326);
			ItemSlotUI.NativeMethodInfoPtr_DuplicateIcon_Public_RectTransform_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681327);
			ItemSlotUI.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681328);
			ItemSlotUI.NativeMethodInfoPtr_OverrideDisplayedQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681329);
			ItemSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100681330);
		}

		// Token: 0x17002BE6 RID: 11238
		// (get) Token: 0x06009050 RID: 36944 RVA: 0x0025B284 File Offset: 0x00259484
		// (set) Token: 0x06009051 RID: 36945 RVA: 0x0025B2C4 File Offset: 0x002594C4
		public unsafe ItemSlot assignedSlot
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_get_assignedSlot_Public_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_set_assignedSlot_Protected_set_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002BE7 RID: 11239
		// (get) Token: 0x06009052 RID: 36946 RVA: 0x0025B308 File Offset: 0x00259508
		// (set) Token: 0x06009053 RID: 36947 RVA: 0x0025B348 File Offset: 0x00259548
		public unsafe ItemUI ItemUI
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 49659, RefRangeEnd = 49699, XrefRangeStart = 49659, XrefRangeEnd = 49699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_get_ItemUI_Public_get_ItemUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_set_ItemUI_Protected_set_Void_ItemUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009054 RID: 36948 RVA: 0x0025B38C File Offset: 0x0025958C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262411, XrefRangeEnd = 262479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignSlot(ItemSlot s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlotUI.NativeMethodInfoPtr_AssignSlot_Public_Virtual_New_Void_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009055 RID: 36949 RVA: 0x0025B3DC File Offset: 0x002595DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262479, XrefRangeEnd = 262529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlotUI.NativeMethodInfoPtr_ClearSlot_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009056 RID: 36950 RVA: 0x0025B418 File Offset: 0x00259618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262529, XrefRangeEnd = 262538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009057 RID: 36951 RVA: 0x0025B44C File Offset: 0x0025964C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262538, XrefRangeEnd = 262562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlotUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009058 RID: 36952 RVA: 0x0025B488 File Offset: 0x00259688
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262563, RefRangeEnd = 262565, XrefRangeStart = 262562, XrefRangeEnd = 262563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHighlighted(bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref h;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetHighlighted_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009059 RID: 36953 RVA: 0x0025B4C8 File Offset: 0x002596C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262566, RefRangeEnd = 262568, XrefRangeStart = 262565, XrefRangeEnd = 262566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormalColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetNormalColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600905A RID: 36954 RVA: 0x0025B508 File Offset: 0x00259708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262569, RefRangeEnd = 262570, XrefRangeStart = 262568, XrefRangeEnd = 262569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHighlightColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetHighlightColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600905B RID: 36955 RVA: 0x0025B548 File Offset: 0x00259748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262570, XrefRangeEnd = 262577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Lock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_Lock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600905C RID: 36956 RVA: 0x0025B57C File Offset: 0x0025977C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262577, XrefRangeEnd = 262584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_Unlock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600905D RID: 36957 RVA: 0x0025B5B0 File Offset: 0x002597B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262584, XrefRangeEnd = 262587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLockVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetLockVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600905E RID: 36958 RVA: 0x0025B5F0 File Offset: 0x002597F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262587, XrefRangeEnd = 262592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overriddenQuantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_DuplicateIcon_Public_RectTransform_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}

		// Token: 0x0600905F RID: 36959 RVA: 0x0025B650 File Offset: 0x00259850
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 262596, RefRangeEnd = 262599, XrefRangeStart = 262592, XrefRangeEnd = 262596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool shown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shown;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009060 RID: 36960 RVA: 0x0025B690 File Offset: 0x00259890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262603, RefRangeEnd = 262604, XrefRangeStart = 262599, XrefRangeEnd = 262603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideDisplayedQuantity(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_OverrideDisplayedQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009061 RID: 36961 RVA: 0x0025B6D0 File Offset: 0x002598D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009062 RID: 36962 RVA: 0x00045193 File Offset: 0x00043393
		public ItemSlotUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x06009063 RID: 36963 RVA: 0x0025B70C File Offset: 0x0025990C
		// (set) Token: 0x06009064 RID: 36964 RVA: 0x0004519C File Offset: 0x0004339C
		public unsafe Color32 normalColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_normalColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_normalColor)) = value;
			}
		}

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x06009065 RID: 36965 RVA: 0x0025B734 File Offset: 0x00259934
		// (set) Token: 0x06009066 RID: 36966 RVA: 0x000451B7 File Offset: 0x000433B7
		public unsafe Color32 highlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_highlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_highlightColor)) = value;
			}
		}

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x06009067 RID: 36967 RVA: 0x0025B75C File Offset: 0x0025995C
		// (set) Token: 0x06009068 RID: 36968 RVA: 0x000451D2 File Offset: 0x000433D2
		public unsafe ItemSlot _assignedSlot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__assignedSlot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__assignedSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x06009069 RID: 36969 RVA: 0x0025B78C File Offset: 0x0025998C
		// (set) Token: 0x0600906A RID: 36970 RVA: 0x000451F1 File Offset: 0x000433F1
		public unsafe bool IsBeingDragged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_IsBeingDragged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_IsBeingDragged)) = value;
			}
		}

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x0600906B RID: 36971 RVA: 0x0025B7B4 File Offset: 0x002599B4
		// (set) Token: 0x0600906C RID: 36972 RVA: 0x0004520C File Offset: 0x0004340C
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x0600906D RID: 36973 RVA: 0x0025B7E4 File Offset: 0x002599E4
		// (set) Token: 0x0600906E RID: 36974 RVA: 0x0004522B File Offset: 0x0004342B
		public unsafe Image Background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x0600906F RID: 36975 RVA: 0x0025B814 File Offset: 0x00259A14
		// (set) Token: 0x06009070 RID: 36976 RVA: 0x0004524A File Offset: 0x0004344A
		public unsafe GameObject LockContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_LockContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_LockContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x06009071 RID: 36977 RVA: 0x0025B844 File Offset: 0x00259A44
		// (set) Token: 0x06009072 RID: 36978 RVA: 0x00045269 File Offset: 0x00043469
		public unsafe RectTransform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x06009073 RID: 36979 RVA: 0x0025B874 File Offset: 0x00259A74
		// (set) Token: 0x06009074 RID: 36980 RVA: 0x00045288 File Offset: 0x00043488
		public unsafe ItemSlotFilterButton FilterButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_FilterButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotFilterButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_FilterButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x06009075 RID: 36981 RVA: 0x0025B8A4 File Offset: 0x00259AA4
		// (set) Token: 0x06009076 RID: 36982 RVA: 0x000452A7 File Offset: 0x000434A7
		public unsafe ItemUI _ItemUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__ItemUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__ItemUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040061BE RID: 25022
		private static readonly IntPtr NativeFieldInfoPtr_normalColor;

		// Token: 0x040061BF RID: 25023
		private static readonly IntPtr NativeFieldInfoPtr_highlightColor;

		// Token: 0x040061C0 RID: 25024
		private static readonly IntPtr NativeFieldInfoPtr__assignedSlot_k__BackingField;

		// Token: 0x040061C1 RID: 25025
		private static readonly IntPtr NativeFieldInfoPtr_IsBeingDragged;

		// Token: 0x040061C2 RID: 25026
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040061C3 RID: 25027
		private static readonly IntPtr NativeFieldInfoPtr_Background;

		// Token: 0x040061C4 RID: 25028
		private static readonly IntPtr NativeFieldInfoPtr_LockContainer;

		// Token: 0x040061C5 RID: 25029
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x040061C6 RID: 25030
		private static readonly IntPtr NativeFieldInfoPtr_FilterButton;

		// Token: 0x040061C7 RID: 25031
		private static readonly IntPtr NativeFieldInfoPtr__ItemUI_k__BackingField;

		// Token: 0x040061C8 RID: 25032
		private static readonly IntPtr NativeMethodInfoPtr_get_assignedSlot_Public_get_ItemSlot_0;

		// Token: 0x040061C9 RID: 25033
		private static readonly IntPtr NativeMethodInfoPtr_set_assignedSlot_Protected_set_Void_ItemSlot_0;

		// Token: 0x040061CA RID: 25034
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemUI_Public_get_ItemUI_0;

		// Token: 0x040061CB RID: 25035
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemUI_Protected_set_Void_ItemUI_0;

		// Token: 0x040061CC RID: 25036
		private static readonly IntPtr NativeMethodInfoPtr_AssignSlot_Public_Virtual_New_Void_ItemSlot_0;

		// Token: 0x040061CD RID: 25037
		private static readonly IntPtr NativeMethodInfoPtr_ClearSlot_Public_Virtual_New_Void_0;

		// Token: 0x040061CE RID: 25038
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x040061CF RID: 25039
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0;

		// Token: 0x040061D0 RID: 25040
		private static readonly IntPtr NativeMethodInfoPtr_SetHighlighted_Public_Void_Boolean_0;

		// Token: 0x040061D1 RID: 25041
		private static readonly IntPtr NativeMethodInfoPtr_SetNormalColor_Public_Void_Color_0;

		// Token: 0x040061D2 RID: 25042
		private static readonly IntPtr NativeMethodInfoPtr_SetHighlightColor_Public_Void_Color_0;

		// Token: 0x040061D3 RID: 25043
		private static readonly IntPtr NativeMethodInfoPtr_Lock_Private_Void_0;

		// Token: 0x040061D4 RID: 25044
		private static readonly IntPtr NativeMethodInfoPtr_Unlock_Private_Void_0;

		// Token: 0x040061D5 RID: 25045
		private static readonly IntPtr NativeMethodInfoPtr_SetLockVisible_Public_Void_Boolean_0;

		// Token: 0x040061D6 RID: 25046
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateIcon_Public_RectTransform_Transform_Int32_0;

		// Token: 0x040061D7 RID: 25047
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x040061D8 RID: 25048
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDisplayedQuantity_Public_Void_Int32_0;

		// Token: 0x040061D9 RID: 25049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
