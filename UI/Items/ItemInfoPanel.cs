using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000741 RID: 1857
	public class ItemInfoPanel : MonoBehaviour
	{
		// Token: 0x0600A649 RID: 42569 RVA: 0x0029D7B0 File Offset: 0x0029B9B0
		// Note: this type is marked as 'beforefieldinit'.
		static ItemInfoPanel()
		{
			Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemInfoPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr);
			ItemInfoPanel.NativeFieldInfoPtr_VERTICAL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "VERTICAL_THRESHOLD");
			ItemInfoPanel.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "<IsOpen>k__BackingField");
			ItemInfoPanel.NativeFieldInfoPtr__CurrentItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "<CurrentItem>k__BackingField");
			ItemInfoPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "Container");
			ItemInfoPanel.NativeFieldInfoPtr_ContentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "ContentContainer");
			ItemInfoPanel.NativeFieldInfoPtr_TopArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "TopArrow");
			ItemInfoPanel.NativeFieldInfoPtr_BottomArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "BottomArrow");
			ItemInfoPanel.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "Canvas");
			ItemInfoPanel.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "Offset");
			ItemInfoPanel.NativeFieldInfoPtr_DefaultContentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "DefaultContentPrefab");
			ItemInfoPanel.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "content");
			ItemInfoPanel.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683747);
			ItemInfoPanel.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683748);
			ItemInfoPanel.NativeMethodInfoPtr_get_CurrentItem_Public_get_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683749);
			ItemInfoPanel.NativeMethodInfoPtr_set_CurrentItem_Protected_set_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683750);
			ItemInfoPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683751);
			ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemInstance_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683752);
			ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683753);
			ItemInfoPanel.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683754);
			ItemInfoPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683755);
		}

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x0600A64A RID: 42570 RVA: 0x0029D970 File Offset: 0x0029BB70
		// (set) Token: 0x0600A64B RID: 42571 RVA: 0x0029D9AC File Offset: 0x0029BBAC
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x0600A64C RID: 42572 RVA: 0x0029D9EC File Offset: 0x0029BBEC
		// (set) Token: 0x0600A64D RID: 42573 RVA: 0x0029DA2C File Offset: 0x0029BC2C
		public unsafe ItemInstance CurrentItem
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_get_CurrentItem_Public_get_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_set_CurrentItem_Protected_set_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A64E RID: 42574 RVA: 0x0029DA70 File Offset: 0x0029BC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290922, XrefRangeEnd = 290923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A64F RID: 42575 RVA: 0x0029DAA4 File Offset: 0x0029BCA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290961, RefRangeEnd = 290962, XrefRangeStart = 290923, XrefRangeEnd = 290961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ItemInstance item, RectTransform rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemInstance_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A650 RID: 42576 RVA: 0x0029DAF8 File Offset: 0x0029BCF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290995, RefRangeEnd = 290996, XrefRangeStart = 290962, XrefRangeEnd = 290995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ItemDefinition def, RectTransform rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A651 RID: 42577 RVA: 0x0029DB4C File Offset: 0x0029BD4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 291008, RefRangeEnd = 291013, XrefRangeStart = 290996, XrefRangeEnd = 291008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A652 RID: 42578 RVA: 0x0029DB80 File Offset: 0x0029BD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291013, XrefRangeEnd = 291014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInfoPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A653 RID: 42579 RVA: 0x00051A77 File Offset: 0x0004FC77
		public ItemInfoPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x0600A654 RID: 42580 RVA: 0x0029DBBC File Offset: 0x0029BDBC
		// (set) Token: 0x0600A655 RID: 42581 RVA: 0x00051A80 File Offset: 0x0004FC80
		public unsafe static float VERTICAL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemInfoPanel.NativeFieldInfoPtr_VERTICAL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemInfoPanel.NativeFieldInfoPtr_VERTICAL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x0600A656 RID: 42582 RVA: 0x0029DBD8 File Offset: 0x0029BDD8
		// (set) Token: 0x0600A657 RID: 42583 RVA: 0x00051A8E File Offset: 0x0004FC8E
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x0600A658 RID: 42584 RVA: 0x0029DC00 File Offset: 0x0029BE00
		// (set) Token: 0x0600A659 RID: 42585 RVA: 0x00051AA9 File Offset: 0x0004FCA9
		public unsafe ItemInstance _CurrentItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__CurrentItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__CurrentItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x0600A65A RID: 42586 RVA: 0x0029DC30 File Offset: 0x0029BE30
		// (set) Token: 0x0600A65B RID: 42587 RVA: 0x00051AC8 File Offset: 0x0004FCC8
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x0600A65C RID: 42588 RVA: 0x0029DC60 File Offset: 0x0029BE60
		// (set) Token: 0x0600A65D RID: 42589 RVA: 0x00051AE7 File Offset: 0x0004FCE7
		public unsafe RectTransform ContentContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_ContentContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_ContentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x0600A65E RID: 42590 RVA: 0x0029DC90 File Offset: 0x0029BE90
		// (set) Token: 0x0600A65F RID: 42591 RVA: 0x00051B06 File Offset: 0x0004FD06
		public unsafe GameObject TopArrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_TopArrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_TopArrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x0600A660 RID: 42592 RVA: 0x0029DCC0 File Offset: 0x0029BEC0
		// (set) Token: 0x0600A661 RID: 42593 RVA: 0x00051B25 File Offset: 0x0004FD25
		public unsafe GameObject BottomArrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_BottomArrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_BottomArrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x0600A662 RID: 42594 RVA: 0x0029DCF0 File Offset: 0x0029BEF0
		// (set) Token: 0x0600A663 RID: 42595 RVA: 0x00051B44 File Offset: 0x0004FD44
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x0600A664 RID: 42596 RVA: 0x0029DD20 File Offset: 0x0029BF20
		// (set) Token: 0x0600A665 RID: 42597 RVA: 0x00051B63 File Offset: 0x0004FD63
		public unsafe Vector2 Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x0600A666 RID: 42598 RVA: 0x0029DD48 File Offset: 0x0029BF48
		// (set) Token: 0x0600A667 RID: 42599 RVA: 0x00051B7E File Offset: 0x0004FD7E
		public unsafe ItemInfoContent DefaultContentPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_DefaultContentPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_DefaultContentPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x0600A668 RID: 42600 RVA: 0x0029DD78 File Offset: 0x0029BF78
		// (set) Token: 0x0600A669 RID: 42601 RVA: 0x00051B9D File Offset: 0x0004FD9D
		public unsafe ItemInfoContent content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006F8A RID: 28554
		private static readonly IntPtr NativeFieldInfoPtr_VERTICAL_THRESHOLD;

		// Token: 0x04006F8B RID: 28555
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006F8C RID: 28556
		private static readonly IntPtr NativeFieldInfoPtr__CurrentItem_k__BackingField;

		// Token: 0x04006F8D RID: 28557
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006F8E RID: 28558
		private static readonly IntPtr NativeFieldInfoPtr_ContentContainer;

		// Token: 0x04006F8F RID: 28559
		private static readonly IntPtr NativeFieldInfoPtr_TopArrow;

		// Token: 0x04006F90 RID: 28560
		private static readonly IntPtr NativeFieldInfoPtr_BottomArrow;

		// Token: 0x04006F91 RID: 28561
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006F92 RID: 28562
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x04006F93 RID: 28563
		private static readonly IntPtr NativeFieldInfoPtr_DefaultContentPrefab;

		// Token: 0x04006F94 RID: 28564
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04006F95 RID: 28565
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006F96 RID: 28566
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006F97 RID: 28567
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentItem_Public_get_ItemInstance_0;

		// Token: 0x04006F98 RID: 28568
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentItem_Protected_set_Void_ItemInstance_0;

		// Token: 0x04006F99 RID: 28569
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006F9A RID: 28570
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ItemInstance_RectTransform_0;

		// Token: 0x04006F9B RID: 28571
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_RectTransform_0;

		// Token: 0x04006F9C RID: 28572
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006F9D RID: 28573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
