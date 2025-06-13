using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x02000411 RID: 1041
	public class InteractableToggleable : MonoBehaviour
	{
		// Token: 0x060054F7 RID: 21751 RVA: 0x00191D28 File Offset: 0x0018FF28
		// Note: this type is marked as 'beforefieldinit'.
		static InteractableToggleable()
		{
			Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "InteractableToggleable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr);
			InteractableToggleable.NativeFieldInfoPtr__IsActivated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "<IsActivated>k__BackingField");
			InteractableToggleable.NativeFieldInfoPtr_ActivateMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "ActivateMessage");
			InteractableToggleable.NativeFieldInfoPtr_DeactivateMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "DeactivateMessage");
			InteractableToggleable.NativeFieldInfoPtr_CoolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "CoolDown");
			InteractableToggleable.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "IntObj");
			InteractableToggleable.NativeFieldInfoPtr_onToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "onToggle");
			InteractableToggleable.NativeFieldInfoPtr_onActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "onActivate");
			InteractableToggleable.NativeFieldInfoPtr_onDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "onDeactivate");
			InteractableToggleable.NativeFieldInfoPtr_lastActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "lastActivated");
			InteractableToggleable.NativeMethodInfoPtr_get_IsActivated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100673997);
			InteractableToggleable.NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100673998);
			InteractableToggleable.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100673999);
			InteractableToggleable.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100674000);
			InteractableToggleable.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100674001);
			InteractableToggleable.NativeMethodInfoPtr_Toggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100674002);
			InteractableToggleable.NativeMethodInfoPtr_SetState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100674003);
			InteractableToggleable.NativeMethodInfoPtr_PoliceDetected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100674004);
			InteractableToggleable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100674005);
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x060054F8 RID: 21752 RVA: 0x00191EC0 File Offset: 0x001900C0
		// (set) Token: 0x060054F9 RID: 21753 RVA: 0x00191EFC File Offset: 0x001900FC
		public unsafe bool IsActivated
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_get_IsActivated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060054FA RID: 21754 RVA: 0x00191F3C File Offset: 0x0019013C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183279, XrefRangeEnd = 183293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054FB RID: 21755 RVA: 0x00191F70 File Offset: 0x00190170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183293, XrefRangeEnd = 183295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054FC RID: 21756 RVA: 0x00191FA4 File Offset: 0x001901A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 183300, RefRangeEnd = 183302, XrefRangeStart = 183295, XrefRangeEnd = 183300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x00191FD8 File Offset: 0x001901D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 183300, RefRangeEnd = 183302, XrefRangeStart = 183300, XrefRangeEnd = 183302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Toggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_Toggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x0019200C File Offset: 0x0019020C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183304, RefRangeEnd = 183305, XrefRangeStart = 183302, XrefRangeEnd = 183304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(bool activated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref activated;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_SetState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x0019204C File Offset: 0x0019024C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183305, XrefRangeEnd = 183309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PoliceDetected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_PoliceDetected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005500 RID: 21760 RVA: 0x00192080 File Offset: 0x00190280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183309, XrefRangeEnd = 183331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractableToggleable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005501 RID: 21761 RVA: 0x000285AF File Offset: 0x000267AF
		public InteractableToggleable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x06005502 RID: 21762 RVA: 0x001920BC File Offset: 0x001902BC
		// (set) Token: 0x06005503 RID: 21763 RVA: 0x000285B8 File Offset: 0x000267B8
		public unsafe bool _IsActivated_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr__IsActivated_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr__IsActivated_k__BackingField)) = value;
			}
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x06005504 RID: 21764 RVA: 0x001920E4 File Offset: 0x001902E4
		// (set) Token: 0x06005505 RID: 21765 RVA: 0x000285D3 File Offset: 0x000267D3
		public unsafe string ActivateMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_ActivateMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_ActivateMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x06005506 RID: 21766 RVA: 0x0019210C File Offset: 0x0019030C
		// (set) Token: 0x06005507 RID: 21767 RVA: 0x000285F2 File Offset: 0x000267F2
		public unsafe string DeactivateMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_DeactivateMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_DeactivateMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x06005508 RID: 21768 RVA: 0x00192134 File Offset: 0x00190334
		// (set) Token: 0x06005509 RID: 21769 RVA: 0x00028611 File Offset: 0x00026811
		public unsafe float CoolDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_CoolDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_CoolDown)) = value;
			}
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x0600550A RID: 21770 RVA: 0x0019215C File Offset: 0x0019035C
		// (set) Token: 0x0600550B RID: 21771 RVA: 0x0002862C File Offset: 0x0002682C
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x0600550C RID: 21772 RVA: 0x0019218C File Offset: 0x0019038C
		// (set) Token: 0x0600550D RID: 21773 RVA: 0x0002864B File Offset: 0x0002684B
		public unsafe UnityEvent onToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x0600550E RID: 21774 RVA: 0x001921BC File Offset: 0x001903BC
		// (set) Token: 0x0600550F RID: 21775 RVA: 0x0002866A File Offset: 0x0002686A
		public unsafe UnityEvent onActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x06005510 RID: 21776 RVA: 0x001921EC File Offset: 0x001903EC
		// (set) Token: 0x06005511 RID: 21777 RVA: 0x00028689 File Offset: 0x00026889
		public unsafe UnityEvent onDeactivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onDeactivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onDeactivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x06005512 RID: 21778 RVA: 0x0019221C File Offset: 0x0019041C
		// (set) Token: 0x06005513 RID: 21779 RVA: 0x000286A8 File Offset: 0x000268A8
		public unsafe float lastActivated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_lastActivated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_lastActivated)) = value;
			}
		}

		// Token: 0x04003994 RID: 14740
		private static readonly IntPtr NativeFieldInfoPtr__IsActivated_k__BackingField;

		// Token: 0x04003995 RID: 14741
		private static readonly IntPtr NativeFieldInfoPtr_ActivateMessage;

		// Token: 0x04003996 RID: 14742
		private static readonly IntPtr NativeFieldInfoPtr_DeactivateMessage;

		// Token: 0x04003997 RID: 14743
		private static readonly IntPtr NativeFieldInfoPtr_CoolDown;

		// Token: 0x04003998 RID: 14744
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04003999 RID: 14745
		private static readonly IntPtr NativeFieldInfoPtr_onToggle;

		// Token: 0x0400399A RID: 14746
		private static readonly IntPtr NativeFieldInfoPtr_onActivate;

		// Token: 0x0400399B RID: 14747
		private static readonly IntPtr NativeFieldInfoPtr_onDeactivate;

		// Token: 0x0400399C RID: 14748
		private static readonly IntPtr NativeFieldInfoPtr_lastActivated;

		// Token: 0x0400399D RID: 14749
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActivated_Public_get_Boolean_0;

		// Token: 0x0400399E RID: 14750
		private static readonly IntPtr NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0;

		// Token: 0x0400399F RID: 14751
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040039A0 RID: 14752
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x040039A1 RID: 14753
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x040039A2 RID: 14754
		private static readonly IntPtr NativeMethodInfoPtr_Toggle_Public_Void_0;

		// Token: 0x040039A3 RID: 14755
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Void_Boolean_0;

		// Token: 0x040039A4 RID: 14756
		private static readonly IntPtr NativeMethodInfoPtr_PoliceDetected_Public_Void_0;

		// Token: 0x040039A5 RID: 14757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
