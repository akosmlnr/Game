using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200037B RID: 891
	public class PatrolGroup : Il2CppSystem.Object
	{
		// Token: 0x0600436F RID: 17263 RVA: 0x001524EC File Offset: 0x001506EC
		// Note: this type is marked as 'beforefieldinit'.
		static PatrolGroup()
		{
			Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "PatrolGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr);
			PatrolGroup.NativeFieldInfoPtr_Members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, "Members");
			PatrolGroup.NativeFieldInfoPtr_Route = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, "Route");
			PatrolGroup.NativeFieldInfoPtr_CurrentWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, "CurrentWaypoint");
			PatrolGroup.NativeMethodInfoPtr__ctor_Public_Void_FootPatrolRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671583);
			PatrolGroup.NativeMethodInfoPtr_GetDestination_Public_Vector3_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671584);
			PatrolGroup.NativeMethodInfoPtr_DisbandGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671585);
			PatrolGroup.NativeMethodInfoPtr_AdvanceGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671586);
			PatrolGroup.NativeMethodInfoPtr_GetMemberOffset_Private_Vector3_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671587);
			PatrolGroup.NativeMethodInfoPtr_IsGroupReadyToAdvance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671588);
			PatrolGroup.NativeMethodInfoPtr_IsPaused_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671589);
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x001525E4 File Offset: 0x001507E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156855, RefRangeEnd = 156856, XrefRangeStart = 156846, XrefRangeEnd = 156855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PatrolGroup(FootPatrolRoute route) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr__ctor_Public_Void_FootPatrolRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x00152630 File Offset: 0x00150830
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 156891, RefRangeEnd = 156897, XrefRangeStart = 156856, XrefRangeEnd = 156891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetDestination(NPC member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_GetDestination_Public_Vector3_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x00152680 File Offset: 0x00150880
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156922, RefRangeEnd = 156924, XrefRangeStart = 156897, XrefRangeEnd = 156922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisbandGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_DisbandGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x001526B4 File Offset: 0x001508B4
		[CallerCount(0)]
		public unsafe void AdvanceGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_AdvanceGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x001526E8 File Offset: 0x001508E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156924, XrefRangeEnd = 156935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetMemberOffset(NPC member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_GetMemberOffset_Private_Vector3_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x00152738 File Offset: 0x00150938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156935, XrefRangeEnd = 156943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGroupReadyToAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_IsGroupReadyToAdvance_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x00152774 File Offset: 0x00150974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156962, RefRangeEnd = 156963, XrefRangeStart = 156943, XrefRangeEnd = 156962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPaused()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_IsPaused_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x00020EFB File Offset: 0x0001F0FB
		public PatrolGroup(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x06004378 RID: 17272 RVA: 0x001527B0 File Offset: 0x001509B0
		// (set) Token: 0x06004379 RID: 17273 RVA: 0x00020F04 File Offset: 0x0001F104
		public unsafe List<NPC> Members
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Members);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Members), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x0600437A RID: 17274 RVA: 0x001527E0 File Offset: 0x001509E0
		// (set) Token: 0x0600437B RID: 17275 RVA: 0x00020F23 File Offset: 0x0001F123
		public unsafe FootPatrolRoute Route
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Route);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootPatrolRoute>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Route), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x0600437C RID: 17276 RVA: 0x00152810 File Offset: 0x00150A10
		// (set) Token: 0x0600437D RID: 17277 RVA: 0x00020F42 File Offset: 0x0001F142
		public unsafe int CurrentWaypoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_CurrentWaypoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_CurrentWaypoint)) = value;
			}
		}

		// Token: 0x04002D0B RID: 11531
		private static readonly System.IntPtr NativeFieldInfoPtr_Members;

		// Token: 0x04002D0C RID: 11532
		private static readonly System.IntPtr NativeFieldInfoPtr_Route;

		// Token: 0x04002D0D RID: 11533
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentWaypoint;

		// Token: 0x04002D0E RID: 11534
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FootPatrolRoute_0;

		// Token: 0x04002D0F RID: 11535
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDestination_Public_Vector3_NPC_0;

		// Token: 0x04002D10 RID: 11536
		private static readonly System.IntPtr NativeMethodInfoPtr_DisbandGroup_Public_Void_0;

		// Token: 0x04002D11 RID: 11537
		private static readonly System.IntPtr NativeMethodInfoPtr_AdvanceGroup_Public_Void_0;

		// Token: 0x04002D12 RID: 11538
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMemberOffset_Private_Vector3_NPC_0;

		// Token: 0x04002D13 RID: 11539
		private static readonly System.IntPtr NativeMethodInfoPtr_IsGroupReadyToAdvance_Public_Boolean_0;

		// Token: 0x04002D14 RID: 11540
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPaused_Public_Boolean_0;
	}
}
