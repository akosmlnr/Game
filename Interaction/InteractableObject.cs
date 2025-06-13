using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x02000410 RID: 1040
	public class InteractableObject : MonoBehaviour
	{
		// Token: 0x060054D0 RID: 21712 RVA: 0x00191634 File Offset: 0x0018F834
		// Note: this type is marked as 'beforefieldinit'.
		static InteractableObject()
		{
			Il2CppClassPointerStore<InteractableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "InteractableObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr);
			InteractableObject.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "message");
			InteractableObject.NativeFieldInfoPtr_interactionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "interactionType");
			InteractableObject.NativeFieldInfoPtr_interactionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "interactionState");
			InteractableObject.NativeFieldInfoPtr_MaxInteractionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "MaxInteractionRange");
			InteractableObject.NativeFieldInfoPtr_RequiresUniqueClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "RequiresUniqueClick");
			InteractableObject.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "Priority");
			InteractableObject.NativeFieldInfoPtr_displayLocationCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "displayLocationCollider");
			InteractableObject.NativeFieldInfoPtr_displayLocationPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "displayLocationPoint");
			InteractableObject.NativeFieldInfoPtr_LimitInteractionAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "LimitInteractionAngle");
			InteractableObject.NativeFieldInfoPtr_AngleLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "AngleLimit");
			InteractableObject.NativeFieldInfoPtr_onHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "onHovered");
			InteractableObject.NativeFieldInfoPtr_onInteractStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "onInteractStart");
			InteractableObject.NativeFieldInfoPtr_onInteractEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "onInteractEnd");
			InteractableObject.NativeMethodInfoPtr_get__interactionType_Public_get_EInteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673986);
			InteractableObject.NativeMethodInfoPtr_get__interactionState_Public_get_EInteractableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673987);
			InteractableObject.NativeMethodInfoPtr_SetInteractionType_Public_Void_EInteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673988);
			InteractableObject.NativeMethodInfoPtr_SetInteractableState_Public_Void_EInteractableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673989);
			InteractableObject.NativeMethodInfoPtr_SetMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673990);
			InteractableObject.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673991);
			InteractableObject.NativeMethodInfoPtr_StartInteract_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673992);
			InteractableObject.NativeMethodInfoPtr_EndInteract_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673993);
			InteractableObject.NativeMethodInfoPtr_ShowMessage_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673994);
			InteractableObject.NativeMethodInfoPtr_CheckAngleLimit_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673995);
			InteractableObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673996);
		}

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x060054D1 RID: 21713 RVA: 0x00191844 File Offset: 0x0018FA44
		public unsafe InteractableObject.EInteractionType _interactionType
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 31426, RefRangeEnd = 31454, XrefRangeStart = 31426, XrefRangeEnd = 31454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_get__interactionType_Public_get_EInteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x060054D2 RID: 21714 RVA: 0x00191880 File Offset: 0x0018FA80
		public unsafe InteractableObject.EInteractableState _interactionState
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 84444, RefRangeEnd = 84470, XrefRangeStart = 84444, XrefRangeEnd = 84470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_get__interactionState_Public_get_EInteractableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060054D3 RID: 21715 RVA: 0x001918BC File Offset: 0x0018FABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31454, RefRangeEnd = 31455, XrefRangeStart = 31454, XrefRangeEnd = 31455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractionType(InteractableObject.EInteractionType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_SetInteractionType_Public_Void_EInteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054D4 RID: 21716 RVA: 0x001918FC File Offset: 0x0018FAFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183194, RefRangeEnd = 183195, XrefRangeStart = 183194, XrefRangeEnd = 183195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractableState(InteractableObject.EInteractableState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_SetInteractableState_Public_Void_EInteractableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x0019193C File Offset: 0x0018FB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMessage(string _message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_message);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_SetMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x00191980 File Offset: 0x0018FB80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183207, RefRangeEnd = 183208, XrefRangeStart = 183206, XrefRangeEnd = 183207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x001919BC File Offset: 0x0018FBBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183214, RefRangeEnd = 183215, XrefRangeStart = 183208, XrefRangeEnd = 183214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_StartInteract_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054D8 RID: 21720 RVA: 0x001919F8 File Offset: 0x0018FBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183215, XrefRangeEnd = 183222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_EndInteract_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x00191A34 File Offset: 0x0018FC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183222, XrefRangeEnd = 183250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_ShowMessage_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054DA RID: 21722 RVA: 0x00191A70 File Offset: 0x0018FC70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183259, RefRangeEnd = 183260, XrefRangeStart = 183250, XrefRangeEnd = 183259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckAngleLimit(Vector3 interactionSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactionSource;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_CheckAngleLimit_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060054DB RID: 21723 RVA: 0x00191ABC File Offset: 0x0018FCBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183278, RefRangeEnd = 183279, XrefRangeStart = 183260, XrefRangeEnd = 183278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractableObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054DC RID: 21724 RVA: 0x0002842F File Offset: 0x0002662F
		public InteractableObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x060054DD RID: 21725 RVA: 0x00191AF8 File Offset: 0x0018FCF8
		// (set) Token: 0x060054DE RID: 21726 RVA: 0x00028438 File Offset: 0x00026638
		public unsafe string message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x060054DF RID: 21727 RVA: 0x00191B20 File Offset: 0x0018FD20
		// (set) Token: 0x060054E0 RID: 21728 RVA: 0x00028457 File Offset: 0x00026657
		public unsafe InteractableObject.EInteractionType interactionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionType)) = value;
			}
		}

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x060054E1 RID: 21729 RVA: 0x00191B48 File Offset: 0x0018FD48
		// (set) Token: 0x060054E2 RID: 21730 RVA: 0x00028472 File Offset: 0x00026672
		public unsafe InteractableObject.EInteractableState interactionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionState)) = value;
			}
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x060054E3 RID: 21731 RVA: 0x00191B70 File Offset: 0x0018FD70
		// (set) Token: 0x060054E4 RID: 21732 RVA: 0x0002848D File Offset: 0x0002668D
		public unsafe float MaxInteractionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_MaxInteractionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_MaxInteractionRange)) = value;
			}
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x060054E5 RID: 21733 RVA: 0x00191B98 File Offset: 0x0018FD98
		// (set) Token: 0x060054E6 RID: 21734 RVA: 0x000284A8 File Offset: 0x000266A8
		public unsafe bool RequiresUniqueClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_RequiresUniqueClick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_RequiresUniqueClick)) = value;
			}
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x060054E7 RID: 21735 RVA: 0x00191BC0 File Offset: 0x0018FDC0
		// (set) Token: 0x060054E8 RID: 21736 RVA: 0x000284C3 File Offset: 0x000266C3
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x060054E9 RID: 21737 RVA: 0x00191BE8 File Offset: 0x0018FDE8
		// (set) Token: 0x060054EA RID: 21738 RVA: 0x000284DE File Offset: 0x000266DE
		public unsafe Collider displayLocationCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x060054EB RID: 21739 RVA: 0x00191C18 File Offset: 0x0018FE18
		// (set) Token: 0x060054EC RID: 21740 RVA: 0x000284FD File Offset: 0x000266FD
		public unsafe Transform displayLocationPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x060054ED RID: 21741 RVA: 0x00191C48 File Offset: 0x0018FE48
		// (set) Token: 0x060054EE RID: 21742 RVA: 0x0002851C File Offset: 0x0002671C
		public unsafe bool LimitInteractionAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_LimitInteractionAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_LimitInteractionAngle)) = value;
			}
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x060054EF RID: 21743 RVA: 0x00191C70 File Offset: 0x0018FE70
		// (set) Token: 0x060054F0 RID: 21744 RVA: 0x00028537 File Offset: 0x00026737
		public unsafe float AngleLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_AngleLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_AngleLimit)) = value;
			}
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x060054F1 RID: 21745 RVA: 0x00191C98 File Offset: 0x0018FE98
		// (set) Token: 0x060054F2 RID: 21746 RVA: 0x00028552 File Offset: 0x00026752
		public unsafe UnityEvent onHovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onHovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onHovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x060054F3 RID: 21747 RVA: 0x00191CC8 File Offset: 0x0018FEC8
		// (set) Token: 0x060054F4 RID: 21748 RVA: 0x00028571 File Offset: 0x00026771
		public unsafe UnityEvent onInteractStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x060054F5 RID: 21749 RVA: 0x00191CF8 File Offset: 0x0018FEF8
		// (set) Token: 0x060054F6 RID: 21750 RVA: 0x00028590 File Offset: 0x00026790
		public unsafe UnityEvent onInteractEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400397C RID: 14716
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x0400397D RID: 14717
		private static readonly IntPtr NativeFieldInfoPtr_interactionType;

		// Token: 0x0400397E RID: 14718
		private static readonly IntPtr NativeFieldInfoPtr_interactionState;

		// Token: 0x0400397F RID: 14719
		private static readonly IntPtr NativeFieldInfoPtr_MaxInteractionRange;

		// Token: 0x04003980 RID: 14720
		private static readonly IntPtr NativeFieldInfoPtr_RequiresUniqueClick;

		// Token: 0x04003981 RID: 14721
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04003982 RID: 14722
		private static readonly IntPtr NativeFieldInfoPtr_displayLocationCollider;

		// Token: 0x04003983 RID: 14723
		private static readonly IntPtr NativeFieldInfoPtr_displayLocationPoint;

		// Token: 0x04003984 RID: 14724
		private static readonly IntPtr NativeFieldInfoPtr_LimitInteractionAngle;

		// Token: 0x04003985 RID: 14725
		private static readonly IntPtr NativeFieldInfoPtr_AngleLimit;

		// Token: 0x04003986 RID: 14726
		private static readonly IntPtr NativeFieldInfoPtr_onHovered;

		// Token: 0x04003987 RID: 14727
		private static readonly IntPtr NativeFieldInfoPtr_onInteractStart;

		// Token: 0x04003988 RID: 14728
		private static readonly IntPtr NativeFieldInfoPtr_onInteractEnd;

		// Token: 0x04003989 RID: 14729
		private static readonly IntPtr NativeMethodInfoPtr_get__interactionType_Public_get_EInteractionType_0;

		// Token: 0x0400398A RID: 14730
		private static readonly IntPtr NativeMethodInfoPtr_get__interactionState_Public_get_EInteractableState_0;

		// Token: 0x0400398B RID: 14731
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractionType_Public_Void_EInteractionType_0;

		// Token: 0x0400398C RID: 14732
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractableState_Public_Void_EInteractableState_0;

		// Token: 0x0400398D RID: 14733
		private static readonly IntPtr NativeMethodInfoPtr_SetMessage_Public_Void_String_0;

		// Token: 0x0400398E RID: 14734
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0;

		// Token: 0x0400398F RID: 14735
		private static readonly IntPtr NativeMethodInfoPtr_StartInteract_Public_Virtual_New_Void_0;

		// Token: 0x04003990 RID: 14736
		private static readonly IntPtr NativeMethodInfoPtr_EndInteract_Public_Virtual_New_Void_0;

		// Token: 0x04003991 RID: 14737
		private static readonly IntPtr NativeMethodInfoPtr_ShowMessage_Protected_Virtual_New_Void_0;

		// Token: 0x04003992 RID: 14738
		private static readonly IntPtr NativeMethodInfoPtr_CheckAngleLimit_Public_Boolean_Vector3_0;

		// Token: 0x04003993 RID: 14739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009FD RID: 2557
		[OriginalName("Assembly-CSharp.dll", "", "EInteractionType")]
		public enum EInteractionType
		{
			// Token: 0x04008D41 RID: 36161
			Key_Press,
			// Token: 0x04008D42 RID: 36162
			LeftMouse_Click
		}

		// Token: 0x020009FE RID: 2558
		[OriginalName("Assembly-CSharp.dll", "", "EInteractableState")]
		public enum EInteractableState
		{
			// Token: 0x04008D44 RID: 36164
			Default,
			// Token: 0x04008D45 RID: 36165
			Invalid,
			// Token: 0x04008D46 RID: 36166
			Disabled,
			// Token: 0x04008D47 RID: 36167
			Label
		}
	}
}
