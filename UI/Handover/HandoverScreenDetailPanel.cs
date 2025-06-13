using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Handover
{
	// Token: 0x0200071C RID: 1820
	public class HandoverScreenDetailPanel : MonoBehaviour
	{
		// Token: 0x0600A223 RID: 41507 RVA: 0x002903E4 File Offset: 0x0028E5E4
		// Note: this type is marked as 'beforefieldinit'.
		static HandoverScreenDetailPanel()
		{
			Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Handover", "HandoverScreenDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr);
			HandoverScreenDetailPanel.NativeFieldInfoPtr_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "LayoutGroup");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "Container");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "NameLabel");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "RelationshipContainer");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "RelationshipScrollbar");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_AddictionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "AddictionContainer");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_AdditionScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "AdditionScrollbar");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "StandardsStar");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "StandardsLabel");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_EffectsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "EffectsLabel");
			HandoverScreenDetailPanel.NativeMethodInfoPtr_Open_Public_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, 100683245);
			HandoverScreenDetailPanel.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, 100683246);
			HandoverScreenDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, 100683247);
		}

		// Token: 0x0600A224 RID: 41508 RVA: 0x00290518 File Offset: 0x0028E718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286099, XrefRangeEnd = 286164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenDetailPanel.NativeMethodInfoPtr_Open_Public_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A225 RID: 41509 RVA: 0x0029055C File Offset: 0x0028E75C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199161, RefRangeEnd = 199164, XrefRangeStart = 199161, XrefRangeEnd = 199164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenDetailPanel.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A226 RID: 41510 RVA: 0x00290590 File Offset: 0x0028E790
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandoverScreenDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A227 RID: 41511 RVA: 0x0004F67C File Offset: 0x0004D87C
		public HandoverScreenDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031BD RID: 12733
		// (get) Token: 0x0600A228 RID: 41512 RVA: 0x002905CC File Offset: 0x0028E7CC
		// (set) Token: 0x0600A229 RID: 41513 RVA: 0x0004F685 File Offset: 0x0004D885
		public unsafe LayoutGroup LayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_LayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031BE RID: 12734
		// (get) Token: 0x0600A22A RID: 41514 RVA: 0x002905FC File Offset: 0x0028E7FC
		// (set) Token: 0x0600A22B RID: 41515 RVA: 0x0004F6A4 File Offset: 0x0004D8A4
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x0600A22C RID: 41516 RVA: 0x0029062C File Offset: 0x0028E82C
		// (set) Token: 0x0600A22D RID: 41517 RVA: 0x0004F6C3 File Offset: 0x0004D8C3
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x0600A22E RID: 41518 RVA: 0x0029065C File Offset: 0x0028E85C
		// (set) Token: 0x0600A22F RID: 41519 RVA: 0x0004F6E2 File Offset: 0x0004D8E2
		public unsafe RectTransform RelationshipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x0600A230 RID: 41520 RVA: 0x0029068C File Offset: 0x0028E88C
		// (set) Token: 0x0600A231 RID: 41521 RVA: 0x0004F701 File Offset: 0x0004D901
		public unsafe Scrollbar RelationshipScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x0600A232 RID: 41522 RVA: 0x002906BC File Offset: 0x0028E8BC
		// (set) Token: 0x0600A233 RID: 41523 RVA: 0x0004F720 File Offset: 0x0004D920
		public unsafe RectTransform AddictionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AddictionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AddictionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x0600A234 RID: 41524 RVA: 0x002906EC File Offset: 0x0028E8EC
		// (set) Token: 0x0600A235 RID: 41525 RVA: 0x0004F73F File Offset: 0x0004D93F
		public unsafe Scrollbar AdditionScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AdditionScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AdditionScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x0600A236 RID: 41526 RVA: 0x0029071C File Offset: 0x0028E91C
		// (set) Token: 0x0600A237 RID: 41527 RVA: 0x0004F75E File Offset: 0x0004D95E
		public unsafe Image StandardsStar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsStar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsStar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x0600A238 RID: 41528 RVA: 0x0029074C File Offset: 0x0028E94C
		// (set) Token: 0x0600A239 RID: 41529 RVA: 0x0004F77D File Offset: 0x0004D97D
		public unsafe TextMeshProUGUI StandardsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x0600A23A RID: 41530 RVA: 0x0029077C File Offset: 0x0028E97C
		// (set) Token: 0x0600A23B RID: 41531 RVA: 0x0004F79C File Offset: 0x0004D99C
		public unsafe TextMeshProUGUI EffectsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_EffectsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_EffectsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006CC5 RID: 27845
		private static readonly IntPtr NativeFieldInfoPtr_LayoutGroup;

		// Token: 0x04006CC6 RID: 27846
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006CC7 RID: 27847
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006CC8 RID: 27848
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipContainer;

		// Token: 0x04006CC9 RID: 27849
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipScrollbar;

		// Token: 0x04006CCA RID: 27850
		private static readonly IntPtr NativeFieldInfoPtr_AddictionContainer;

		// Token: 0x04006CCB RID: 27851
		private static readonly IntPtr NativeFieldInfoPtr_AdditionScrollbar;

		// Token: 0x04006CCC RID: 27852
		private static readonly IntPtr NativeFieldInfoPtr_StandardsStar;

		// Token: 0x04006CCD RID: 27853
		private static readonly IntPtr NativeFieldInfoPtr_StandardsLabel;

		// Token: 0x04006CCE RID: 27854
		private static readonly IntPtr NativeFieldInfoPtr_EffectsLabel;

		// Token: 0x04006CCF RID: 27855
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_Customer_0;

		// Token: 0x04006CD0 RID: 27856
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006CD1 RID: 27857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
