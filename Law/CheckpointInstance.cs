using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003E1 RID: 993
	[System.Serializable]
	public class CheckpointInstance : Il2CppSystem.Object
	{
		// Token: 0x06004C57 RID: 19543 RVA: 0x0017311C File Offset: 0x0017131C
		// Note: this type is marked as 'beforefieldinit'.
		static CheckpointInstance()
		{
			Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "CheckpointInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr);
			CheckpointInstance.NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "MIN_ACTIVATION_DISTANCE");
			CheckpointInstance.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "Location");
			CheckpointInstance.NativeFieldInfoPtr_Members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "Members");
			CheckpointInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "StartTime");
			CheckpointInstance.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "EndTime");
			CheckpointInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "IntensityRequirement");
			CheckpointInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			CheckpointInstance.NativeFieldInfoPtr_checkPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "checkPoint");
			CheckpointInstance.NativeFieldInfoPtr__activeCheckpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "<activeCheckpoint>k__BackingField");
			CheckpointInstance.NativeMethodInfoPtr_get_activeCheckpoint_Public_get_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672844);
			CheckpointInstance.NativeMethodInfoPtr_set_activeCheckpoint_Protected_set_Void_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672845);
			CheckpointInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672846);
			CheckpointInstance.NativeMethodInfoPtr_EnableCheckpoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672847);
			CheckpointInstance.NativeMethodInfoPtr_DistanceRequirementsMet_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672848);
			CheckpointInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672849);
			CheckpointInstance.NativeMethodInfoPtr_DisableCheckpoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672850);
			CheckpointInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672851);
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06004C58 RID: 19544 RVA: 0x001732A0 File Offset: 0x001714A0
		// (set) Token: 0x06004C59 RID: 19545 RVA: 0x001732E0 File Offset: 0x001714E0
		public unsafe RoadCheckpoint activeCheckpoint
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_get_activeCheckpoint_Public_get_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_set_activeCheckpoint_Protected_set_Void_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004C5A RID: 19546 RVA: 0x00173324 File Offset: 0x00171524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169075, RefRangeEnd = 169076, XrefRangeStart = 169047, XrefRangeEnd = 169075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x00173358 File Offset: 0x00171558
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169114, RefRangeEnd = 169115, XrefRangeStart = 169076, XrefRangeEnd = 169114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableCheckpoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_EnableCheckpoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x0017338C File Offset: 0x0017158C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169136, RefRangeEnd = 169138, XrefRangeStart = 169115, XrefRangeEnd = 169136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DistanceRequirementsMet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_DistanceRequirementsMet_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x001733C8 File Offset: 0x001715C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169138, XrefRangeEnd = 169145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x001733FC File Offset: 0x001715FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169175, RefRangeEnd = 169176, XrefRangeStart = 169145, XrefRangeEnd = 169175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableCheckpoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_DisableCheckpoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x00173430 File Offset: 0x00171630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169176, XrefRangeEnd = 169177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckpointInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x0002494C File Offset: 0x00022B4C
		public CheckpointInstance(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x06004C61 RID: 19553 RVA: 0x0017346C File Offset: 0x0017166C
		// (set) Token: 0x06004C62 RID: 19554 RVA: 0x00024955 File Offset: 0x00022B55
		public unsafe static float MIN_ACTIVATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CheckpointInstance.NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CheckpointInstance.NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x06004C63 RID: 19555 RVA: 0x00173488 File Offset: 0x00171688
		// (set) Token: 0x06004C64 RID: 19556 RVA: 0x00024963 File Offset: 0x00022B63
		public unsafe CheckpointManager.ECheckpointLocation Location
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_Location);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_Location)) = value;
			}
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06004C65 RID: 19557 RVA: 0x001734B0 File Offset: 0x001716B0
		// (set) Token: 0x06004C66 RID: 19558 RVA: 0x0002497E File Offset: 0x00022B7E
		public unsafe int Members
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_Members);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_Members)) = value;
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06004C67 RID: 19559 RVA: 0x001734D8 File Offset: 0x001716D8
		// (set) Token: 0x06004C68 RID: 19560 RVA: 0x00024999 File Offset: 0x00022B99
		public unsafe int StartTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06004C69 RID: 19561 RVA: 0x00173500 File Offset: 0x00171700
		// (set) Token: 0x06004C6A RID: 19562 RVA: 0x000249B4 File Offset: 0x00022BB4
		public unsafe int EndTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06004C6B RID: 19563 RVA: 0x00173528 File Offset: 0x00171728
		// (set) Token: 0x06004C6C RID: 19564 RVA: 0x000249CF File Offset: 0x00022BCF
		public unsafe int IntensityRequirement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06004C6D RID: 19565 RVA: 0x00173550 File Offset: 0x00171750
		// (set) Token: 0x06004C6E RID: 19566 RVA: 0x000249EA File Offset: 0x00022BEA
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06004C6F RID: 19567 RVA: 0x00173578 File Offset: 0x00171778
		// (set) Token: 0x06004C70 RID: 19568 RVA: 0x00024A05 File Offset: 0x00022C05
		public unsafe RoadCheckpoint checkPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_checkPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_checkPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06004C71 RID: 19569 RVA: 0x001735A8 File Offset: 0x001717A8
		// (set) Token: 0x06004C72 RID: 19570 RVA: 0x00024A24 File Offset: 0x00022C24
		public unsafe RoadCheckpoint _activeCheckpoint_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr__activeCheckpoint_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr__activeCheckpoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400337D RID: 13181
		private static readonly System.IntPtr NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE;

		// Token: 0x0400337E RID: 13182
		private static readonly System.IntPtr NativeFieldInfoPtr_Location;

		// Token: 0x0400337F RID: 13183
		private static readonly System.IntPtr NativeFieldInfoPtr_Members;

		// Token: 0x04003380 RID: 13184
		private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04003381 RID: 13185
		private static readonly System.IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04003382 RID: 13186
		private static readonly System.IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x04003383 RID: 13187
		private static readonly System.IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x04003384 RID: 13188
		private static readonly System.IntPtr NativeFieldInfoPtr_checkPoint;

		// Token: 0x04003385 RID: 13189
		private static readonly System.IntPtr NativeFieldInfoPtr__activeCheckpoint_k__BackingField;

		// Token: 0x04003386 RID: 13190
		private static readonly System.IntPtr NativeMethodInfoPtr_get_activeCheckpoint_Public_get_RoadCheckpoint_0;

		// Token: 0x04003387 RID: 13191
		private static readonly System.IntPtr NativeMethodInfoPtr_set_activeCheckpoint_Protected_set_Void_RoadCheckpoint_0;

		// Token: 0x04003388 RID: 13192
		private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x04003389 RID: 13193
		private static readonly System.IntPtr NativeMethodInfoPtr_EnableCheckpoint_Public_Void_0;

		// Token: 0x0400338A RID: 13194
		private static readonly System.IntPtr NativeMethodInfoPtr_DistanceRequirementsMet_Private_Boolean_0;

		// Token: 0x0400338B RID: 13195
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400338C RID: 13196
		private static readonly System.IntPtr NativeMethodInfoPtr_DisableCheckpoint_Public_Void_0;

		// Token: 0x0400338D RID: 13197
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
