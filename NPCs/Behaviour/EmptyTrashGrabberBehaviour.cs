using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200036B RID: 875
	public class EmptyTrashGrabberBehaviour : Behaviour
	{
		// Token: 0x060040C3 RID: 16579 RVA: 0x00148054 File Offset: 0x00146254
		// Note: this type is marked as 'beforefieldinit'.
		static EmptyTrashGrabberBehaviour()
		{
			Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "EmptyTrashGrabberBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr);
			EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_ACTION_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "ACTION_MAX_DISTANCE");
			EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_EQUIPPABLE_ASSET_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "EQUIPPABLE_ASSET_PATH");
			EmptyTrashGrabberBehaviour.NativeFieldInfoPtr__TargetTrashCan_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "<TargetTrashCan>k__BackingField");
			EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_actionCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "actionCoroutine");
			EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_onPerfomAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "onPerfomAction");
			EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.EmptyTrashGrabberBehaviourAssembly-CSharp.dll_Excuted");
			EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.EmptyTrashGrabberBehaviourAssembly-CSharp.dll_Excuted");
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_get_TargetTrashCan_Public_get_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671062);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_set_TargetTrashCan_Private_set_Void_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671063);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_get_Cleaner_Private_get_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671064);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_SetTargetTrashCan_Public_Void_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671065);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671066);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671067);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_StartAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671068);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671069);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671070);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671071);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_StopAllActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671072);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671073);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_GoToTarget_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671074);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_PerformAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671075);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671076);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671077);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671078);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671079);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671080);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671081);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671082);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_PerformAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671083);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_RpcLogic___PerformAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671084);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_RpcReader___Observers_PerformAction_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671085);
			EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, 100671086);
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x060040C4 RID: 16580 RVA: 0x00148304 File Offset: 0x00146504
		// (set) Token: 0x060040C5 RID: 16581 RVA: 0x00148344 File Offset: 0x00146544
		public unsafe TrashContainerItem TargetTrashCan
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_get_TargetTrashCan_Public_get_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainerItem>(intPtr2) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 118576, RefRangeEnd = 118584, XrefRangeStart = 118576, XrefRangeEnd = 118584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_set_TargetTrashCan_Private_set_Void_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x060040C6 RID: 16582 RVA: 0x00148388 File Offset: 0x00146588
		public unsafe Cleaner Cleaner
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 152672, RefRangeEnd = 152675, XrefRangeStart = 152670, XrefRangeEnd = 152672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_get_Cleaner_Private_get_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
			}
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x001483C8 File Offset: 0x001465C8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 118576, RefRangeEnd = 118584, XrefRangeStart = 118576, XrefRangeEnd = 118584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetTrashCan(TrashContainerItem trashCan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashCan);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_SetTargetTrashCan_Public_Void_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x0014840C File Offset: 0x0014660C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152675, XrefRangeEnd = 152677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x00148448 File Offset: 0x00146648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152677, XrefRangeEnd = 152679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040CA RID: 16586 RVA: 0x00148484 File Offset: 0x00146684
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 152688, RefRangeEnd = 152690, XrefRangeStart = 152679, XrefRangeEnd = 152688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_StartAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x001484B8 File Offset: 0x001466B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152690, XrefRangeEnd = 152692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040CC RID: 16588 RVA: 0x001484F4 File Offset: 0x001466F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x00148530 File Offset: 0x00146730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152692, XrefRangeEnd = 152694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x0014856C File Offset: 0x0014676C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 152702, RefRangeEnd = 152704, XrefRangeStart = 152694, XrefRangeEnd = 152702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_StopAllActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040CF RID: 16591 RVA: 0x001485A0 File Offset: 0x001467A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152704, XrefRangeEnd = 152727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x001485DC File Offset: 0x001467DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152727, XrefRangeEnd = 152738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_GoToTarget_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x00148610 File Offset: 0x00146810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152738, XrefRangeEnd = 152759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_PerformAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x00148644 File Offset: 0x00146844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x00148680 File Offset: 0x00146880
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 152769, RefRangeEnd = 152774, XrefRangeStart = 152759, XrefRangeEnd = 152769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreActionConditionsMet(bool checkAccess)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref checkAccess;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060040D4 RID: 16596 RVA: 0x001486CC File Offset: 0x001468CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmptyTrashGrabberBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040D5 RID: 16597 RVA: 0x00148708 File Offset: 0x00146908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152774, XrefRangeEnd = 152779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x00148748 File Offset: 0x00146948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152779, XrefRangeEnd = 152787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x00148784 File Offset: 0x00146984
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040D8 RID: 16600 RVA: 0x001487C0 File Offset: 0x001469C0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x001487FC File Offset: 0x001469FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152787, XrefRangeEnd = 152796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PerformAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_PerformAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x00148830 File Offset: 0x00146A30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 152807, RefRangeEnd = 152809, XrefRangeStart = 152796, XrefRangeEnd = 152807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PerformAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_RpcLogic___PerformAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x00148864 File Offset: 0x00146A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152809, XrefRangeEnd = 152812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PerformAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_RpcReader___Observers_PerformAction_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040DC RID: 16604 RVA: 0x001488B4 File Offset: 0x00146AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyTrashGrabberBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x000201E0 File Offset: 0x0001E3E0
		public EmptyTrashGrabberBehaviour(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x060040DE RID: 16606 RVA: 0x001488F0 File Offset: 0x00146AF0
		// (set) Token: 0x060040DF RID: 16607 RVA: 0x000201E9 File Offset: 0x0001E3E9
		public unsafe static float ACTION_MAX_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_ACTION_MAX_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_ACTION_MAX_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x060040E0 RID: 16608 RVA: 0x0014890C File Offset: 0x00146B0C
		// (set) Token: 0x060040E1 RID: 16609 RVA: 0x000201F7 File Offset: 0x0001E3F7
		public unsafe static string EQUIPPABLE_ASSET_PATH
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_EQUIPPABLE_ASSET_PATH, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_EQUIPPABLE_ASSET_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x060040E2 RID: 16610 RVA: 0x0014892C File Offset: 0x00146B2C
		// (set) Token: 0x060040E3 RID: 16611 RVA: 0x00020209 File Offset: 0x0001E409
		public unsafe TrashContainerItem _TargetTrashCan_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr__TargetTrashCan_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainerItem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr__TargetTrashCan_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x060040E4 RID: 16612 RVA: 0x0014895C File Offset: 0x00146B5C
		// (set) Token: 0x060040E5 RID: 16613 RVA: 0x00020228 File Offset: 0x0001E428
		public unsafe Coroutine actionCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_actionCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_actionCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x060040E6 RID: 16614 RVA: 0x0014898C File Offset: 0x00146B8C
		// (set) Token: 0x060040E7 RID: 16615 RVA: 0x00020247 File Offset: 0x0001E447
		public unsafe UnityEvent onPerfomAction
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_onPerfomAction);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_onPerfomAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x060040E8 RID: 16616 RVA: 0x001489BC File Offset: 0x00146BBC
		// (set) Token: 0x060040E9 RID: 16617 RVA: 0x00020266 File Offset: 0x0001E466
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x060040EA RID: 16618 RVA: 0x001489E4 File Offset: 0x00146BE4
		// (set) Token: 0x060040EB RID: 16619 RVA: 0x00020281 File Offset: 0x0001E481
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002AF8 RID: 11000
		private static readonly System.IntPtr NativeFieldInfoPtr_ACTION_MAX_DISTANCE;

		// Token: 0x04002AF9 RID: 11001
		private static readonly System.IntPtr NativeFieldInfoPtr_EQUIPPABLE_ASSET_PATH;

		// Token: 0x04002AFA RID: 11002
		private static readonly System.IntPtr NativeFieldInfoPtr__TargetTrashCan_k__BackingField;

		// Token: 0x04002AFB RID: 11003
		private static readonly System.IntPtr NativeFieldInfoPtr_actionCoroutine;

		// Token: 0x04002AFC RID: 11004
		private static readonly System.IntPtr NativeFieldInfoPtr_onPerfomAction;

		// Token: 0x04002AFD RID: 11005
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002AFE RID: 11006
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002AFF RID: 11007
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetTrashCan_Public_get_TrashContainerItem_0;

		// Token: 0x04002B00 RID: 11008
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetTrashCan_Private_set_Void_TrashContainerItem_0;

		// Token: 0x04002B01 RID: 11009
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Cleaner_Private_get_Cleaner_0;

		// Token: 0x04002B02 RID: 11010
		private static readonly System.IntPtr NativeMethodInfoPtr_SetTargetTrashCan_Public_Void_TrashContainerItem_0;

		// Token: 0x04002B03 RID: 11011
		private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002B04 RID: 11012
		private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002B05 RID: 11013
		private static readonly System.IntPtr NativeMethodInfoPtr_StartAction_Private_Void_0;

		// Token: 0x04002B06 RID: 11014
		private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002B07 RID: 11015
		private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002B08 RID: 11016
		private static readonly System.IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002B09 RID: 11017
		private static readonly System.IntPtr NativeMethodInfoPtr_StopAllActions_Private_Void_0;

		// Token: 0x04002B0A RID: 11018
		private static readonly System.IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002B0B RID: 11019
		private static readonly System.IntPtr NativeMethodInfoPtr_GoToTarget_Private_Void_0;

		// Token: 0x04002B0C RID: 11020
		private static readonly System.IntPtr NativeMethodInfoPtr_PerformAction_Private_Void_0;

		// Token: 0x04002B0D RID: 11021
		private static readonly System.IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x04002B0E RID: 11022
		private static readonly System.IntPtr NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_Boolean_0;

		// Token: 0x04002B0F RID: 11023
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B10 RID: 11024
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002B11 RID: 11025
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002B12 RID: 11026
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002B13 RID: 11027
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002B14 RID: 11028
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PerformAction_2166136261_Private_Void_0;

		// Token: 0x04002B15 RID: 11029
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___PerformAction_2166136261_Private_Void_0;

		// Token: 0x04002B16 RID: 11030
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_PerformAction_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002B17 RID: 11031
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000992 RID: 2450
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.EmptyTrashGrabberBehaviour+<<PerformAction>g__Action|20_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CCE6 RID: 52454 RVA: 0x0031CDC8 File Offset: 0x0031AFC8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique()
			{
				Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour>.NativeClassPtr, "<<PerformAction>g__Action|20_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr);
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, "<>1__state");
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, "<>2__current");
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, "<>4__this");
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, 100671087);
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, 100671088);
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, 100671089);
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, 100671090);
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, 100671091);
				EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr, 100671092);
			}

			// Token: 0x0600CCE7 RID: 52455 RVA: 0x0031CEA8 File Offset: 0x0031B0A8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CCE8 RID: 52456 RVA: 0x0031CEF0 File Offset: 0x0031B0F0
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CCE9 RID: 52457 RVA: 0x0031CF24 File Offset: 0x0031B124
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152613, XrefRangeEnd = 152665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003F8F RID: 16271
			// (get) Token: 0x0600CCEA RID: 52458 RVA: 0x0031CF60 File Offset: 0x0031B160
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CCEB RID: 52459 RVA: 0x0031CFA0 File Offset: 0x0031B1A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152665, XrefRangeEnd = 152670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003F90 RID: 16272
			// (get) Token: 0x0600CCEC RID: 52460 RVA: 0x0031CFD4 File Offset: 0x0031B1D4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CCED RID: 52461 RVA: 0x000635F3 File Offset: 0x000617F3
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F8C RID: 16268
			// (get) Token: 0x0600CCEE RID: 52462 RVA: 0x0031D014 File Offset: 0x0031B214
			// (set) Token: 0x0600CCEF RID: 52463 RVA: 0x000635FC File Offset: 0x000617FC
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F8D RID: 16269
			// (get) Token: 0x0600CCF0 RID: 52464 RVA: 0x0031D03C File Offset: 0x0031B23C
			// (set) Token: 0x0600CCF1 RID: 52465 RVA: 0x00063617 File Offset: 0x00061817
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F8E RID: 16270
			// (get) Token: 0x0600CCF2 RID: 52466 RVA: 0x0031D06C File Offset: 0x0031B26C
			// (set) Token: 0x0600CCF3 RID: 52467 RVA: 0x00063636 File Offset: 0x00061836
			public unsafe EmptyTrashGrabberBehaviour __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmptyTrashGrabberBehaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyTrashGrabberBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEmObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AB3 RID: 35507
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008AB4 RID: 35508
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008AB5 RID: 35509
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AB6 RID: 35510
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008AB7 RID: 35511
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AB8 RID: 35512
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008AB9 RID: 35513
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008ABA RID: 35514
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008ABB RID: 35515
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
