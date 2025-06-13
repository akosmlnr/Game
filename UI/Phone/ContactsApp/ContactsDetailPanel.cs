using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.ContactsApp
{
	// Token: 0x020006DB RID: 1755
	public class ContactsDetailPanel : MonoBehaviour
	{
		// Token: 0x06009D5B RID: 40283 RVA: 0x002818D4 File Offset: 0x0027FAD4
		// Note: this type is marked as 'beforefieldinit'.
		static ContactsDetailPanel()
		{
			Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ContactsApp", "ContactsDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr);
			ContactsDetailPanel.NativeFieldInfoPtr__SelectedNPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "<SelectedNPC>k__BackingField");
			ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "DependenceColor_Min");
			ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "DependenceColor_Max");
			ContactsDetailPanel.NativeFieldInfoPtr_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "LayoutGroup");
			ContactsDetailPanel.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "NameLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_TypeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "TypeLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_UnlockHintLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "UnlockHintLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_RelationshipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "RelationshipContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "RelationshipScrollbar");
			ContactsDetailPanel.NativeFieldInfoPtr_RelationshipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "RelationshipLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_AddictionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "AddictionContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_AddictionScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "AddictionScrollbar");
			ContactsDetailPanel.NativeFieldInfoPtr_AddictionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "AddictionLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_PropertiesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "PropertiesContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_PropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "PropertiesLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_ShowOnMapButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "ShowOnMapButton");
			ContactsDetailPanel.NativeFieldInfoPtr_StandardsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "StandardsContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_StandardsStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "StandardsStar");
			ContactsDetailPanel.NativeFieldInfoPtr_StandardsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "StandardsLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_poi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "poi");
			ContactsDetailPanel.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100682765);
			ContactsDetailPanel.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100682766);
			ContactsDetailPanel.NativeMethodInfoPtr_Open_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100682767);
			ContactsDetailPanel.NativeMethodInfoPtr_ShowOnMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100682768);
			ContactsDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100682769);
		}

		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x06009D5C RID: 40284 RVA: 0x00281AF8 File Offset: 0x0027FCF8
		// (set) Token: 0x06009D5D RID: 40285 RVA: 0x00281B38 File Offset: 0x0027FD38
		public unsafe NPC SelectedNPC
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009D5E RID: 40286 RVA: 0x00281B7C File Offset: 0x0027FD7C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 279841, RefRangeEnd = 279847, XrefRangeStart = 279714, XrefRangeEnd = 279841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_Open_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D5F RID: 40287 RVA: 0x00281BC0 File Offset: 0x0027FDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279847, XrefRangeEnd = 279880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOnMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_ShowOnMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D60 RID: 40288 RVA: 0x00281BF4 File Offset: 0x0027FDF4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContactsDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D61 RID: 40289 RVA: 0x0004CC2C File Offset: 0x0004AE2C
		public ContactsDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700303F RID: 12351
		// (get) Token: 0x06009D62 RID: 40290 RVA: 0x00281C30 File Offset: 0x0027FE30
		// (set) Token: 0x06009D63 RID: 40291 RVA: 0x0004CC35 File Offset: 0x0004AE35
		public unsafe NPC _SelectedNPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr__SelectedNPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr__SelectedNPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003040 RID: 12352
		// (get) Token: 0x06009D64 RID: 40292 RVA: 0x00281C60 File Offset: 0x0027FE60
		// (set) Token: 0x06009D65 RID: 40293 RVA: 0x0004CC54 File Offset: 0x0004AE54
		public unsafe Color DependenceColor_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Min)) = value;
			}
		}

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x06009D66 RID: 40294 RVA: 0x00281C88 File Offset: 0x0027FE88
		// (set) Token: 0x06009D67 RID: 40295 RVA: 0x0004CC6F File Offset: 0x0004AE6F
		public unsafe Color DependenceColor_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Max)) = value;
			}
		}

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x06009D68 RID: 40296 RVA: 0x00281CB0 File Offset: 0x0027FEB0
		// (set) Token: 0x06009D69 RID: 40297 RVA: 0x0004CC8A File Offset: 0x0004AE8A
		public unsafe VerticalLayoutGroup LayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_LayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x06009D6A RID: 40298 RVA: 0x00281CE0 File Offset: 0x0027FEE0
		// (set) Token: 0x06009D6B RID: 40299 RVA: 0x0004CCA9 File Offset: 0x0004AEA9
		public unsafe Text NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x06009D6C RID: 40300 RVA: 0x00281D10 File Offset: 0x0027FF10
		// (set) Token: 0x06009D6D RID: 40301 RVA: 0x0004CCC8 File Offset: 0x0004AEC8
		public unsafe Text TypeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_TypeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_TypeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x06009D6E RID: 40302 RVA: 0x00281D40 File Offset: 0x0027FF40
		// (set) Token: 0x06009D6F RID: 40303 RVA: 0x0004CCE7 File Offset: 0x0004AEE7
		public unsafe Text UnlockHintLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_UnlockHintLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_UnlockHintLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x06009D70 RID: 40304 RVA: 0x00281D70 File Offset: 0x0027FF70
		// (set) Token: 0x06009D71 RID: 40305 RVA: 0x0004CD06 File Offset: 0x0004AF06
		public unsafe RectTransform RelationshipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003047 RID: 12359
		// (get) Token: 0x06009D72 RID: 40306 RVA: 0x00281DA0 File Offset: 0x0027FFA0
		// (set) Token: 0x06009D73 RID: 40307 RVA: 0x0004CD25 File Offset: 0x0004AF25
		public unsafe Scrollbar RelationshipScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x06009D74 RID: 40308 RVA: 0x00281DD0 File Offset: 0x0027FFD0
		// (set) Token: 0x06009D75 RID: 40309 RVA: 0x0004CD44 File Offset: 0x0004AF44
		public unsafe Text RelationshipLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x06009D76 RID: 40310 RVA: 0x00281E00 File Offset: 0x00280000
		// (set) Token: 0x06009D77 RID: 40311 RVA: 0x0004CD63 File Offset: 0x0004AF63
		public unsafe RectTransform AddictionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x06009D78 RID: 40312 RVA: 0x00281E30 File Offset: 0x00280030
		// (set) Token: 0x06009D79 RID: 40313 RVA: 0x0004CD82 File Offset: 0x0004AF82
		public unsafe Scrollbar AddictionScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700304B RID: 12363
		// (get) Token: 0x06009D7A RID: 40314 RVA: 0x00281E60 File Offset: 0x00280060
		// (set) Token: 0x06009D7B RID: 40315 RVA: 0x0004CDA1 File Offset: 0x0004AFA1
		public unsafe Text AddictionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700304C RID: 12364
		// (get) Token: 0x06009D7C RID: 40316 RVA: 0x00281E90 File Offset: 0x00280090
		// (set) Token: 0x06009D7D RID: 40317 RVA: 0x0004CDC0 File Offset: 0x0004AFC0
		public unsafe RectTransform PropertiesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700304D RID: 12365
		// (get) Token: 0x06009D7E RID: 40318 RVA: 0x00281EC0 File Offset: 0x002800C0
		// (set) Token: 0x06009D7F RID: 40319 RVA: 0x0004CDDF File Offset: 0x0004AFDF
		public unsafe Text PropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700304E RID: 12366
		// (get) Token: 0x06009D80 RID: 40320 RVA: 0x00281EF0 File Offset: 0x002800F0
		// (set) Token: 0x06009D81 RID: 40321 RVA: 0x0004CDFE File Offset: 0x0004AFFE
		public unsafe Button ShowOnMapButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_ShowOnMapButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_ShowOnMapButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x06009D82 RID: 40322 RVA: 0x00281F20 File Offset: 0x00280120
		// (set) Token: 0x06009D83 RID: 40323 RVA: 0x0004CE1D File Offset: 0x0004B01D
		public unsafe RectTransform StandardsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x06009D84 RID: 40324 RVA: 0x00281F50 File Offset: 0x00280150
		// (set) Token: 0x06009D85 RID: 40325 RVA: 0x0004CE3C File Offset: 0x0004B03C
		public unsafe Image StandardsStar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsStar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsStar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x06009D86 RID: 40326 RVA: 0x00281F80 File Offset: 0x00280180
		// (set) Token: 0x06009D87 RID: 40327 RVA: 0x0004CE5B File Offset: 0x0004B05B
		public unsafe Text StandardsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x06009D88 RID: 40328 RVA: 0x00281FB0 File Offset: 0x002801B0
		// (set) Token: 0x06009D89 RID: 40329 RVA: 0x0004CE7A File Offset: 0x0004B07A
		public unsafe POI poi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_poi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_poi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069D7 RID: 27095
		private static readonly IntPtr NativeFieldInfoPtr__SelectedNPC_k__BackingField;

		// Token: 0x040069D8 RID: 27096
		private static readonly IntPtr NativeFieldInfoPtr_DependenceColor_Min;

		// Token: 0x040069D9 RID: 27097
		private static readonly IntPtr NativeFieldInfoPtr_DependenceColor_Max;

		// Token: 0x040069DA RID: 27098
		private static readonly IntPtr NativeFieldInfoPtr_LayoutGroup;

		// Token: 0x040069DB RID: 27099
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x040069DC RID: 27100
		private static readonly IntPtr NativeFieldInfoPtr_TypeLabel;

		// Token: 0x040069DD RID: 27101
		private static readonly IntPtr NativeFieldInfoPtr_UnlockHintLabel;

		// Token: 0x040069DE RID: 27102
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipContainer;

		// Token: 0x040069DF RID: 27103
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipScrollbar;

		// Token: 0x040069E0 RID: 27104
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipLabel;

		// Token: 0x040069E1 RID: 27105
		private static readonly IntPtr NativeFieldInfoPtr_AddictionContainer;

		// Token: 0x040069E2 RID: 27106
		private static readonly IntPtr NativeFieldInfoPtr_AddictionScrollbar;

		// Token: 0x040069E3 RID: 27107
		private static readonly IntPtr NativeFieldInfoPtr_AddictionLabel;

		// Token: 0x040069E4 RID: 27108
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesContainer;

		// Token: 0x040069E5 RID: 27109
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesLabel;

		// Token: 0x040069E6 RID: 27110
		private static readonly IntPtr NativeFieldInfoPtr_ShowOnMapButton;

		// Token: 0x040069E7 RID: 27111
		private static readonly IntPtr NativeFieldInfoPtr_StandardsContainer;

		// Token: 0x040069E8 RID: 27112
		private static readonly IntPtr NativeFieldInfoPtr_StandardsStar;

		// Token: 0x040069E9 RID: 27113
		private static readonly IntPtr NativeFieldInfoPtr_StandardsLabel;

		// Token: 0x040069EA RID: 27114
		private static readonly IntPtr NativeFieldInfoPtr_poi;

		// Token: 0x040069EB RID: 27115
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0;

		// Token: 0x040069EC RID: 27116
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0;

		// Token: 0x040069ED RID: 27117
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_NPC_0;

		// Token: 0x040069EE RID: 27118
		private static readonly IntPtr NativeMethodInfoPtr_ShowOnMap_Public_Void_0;

		// Token: 0x040069EF RID: 27119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
