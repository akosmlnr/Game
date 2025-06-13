using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000181 RID: 385
	public class VisionEvent : Il2CppSystem.Object
	{
		// Token: 0x06001EBD RID: 7869 RVA: 0x000D2FD8 File Offset: 0x000D11D8
		// Note: this type is marked as 'beforefieldinit'.
		static VisionEvent()
		{
			Il2CppClassPointerStore<VisionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisionEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr);
			VisionEvent.NativeFieldInfoPtr_NOTICE_DROP_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "NOTICE_DROP_THRESHOLD");
			VisionEvent.NativeFieldInfoPtr__Target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "<Target>k__BackingField");
			VisionEvent.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "<State>k__BackingField");
			VisionEvent.NativeFieldInfoPtr__Owner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "<Owner>k__BackingField");
			VisionEvent.NativeFieldInfoPtr__FullNoticeTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "<FullNoticeTime>k__BackingField");
			VisionEvent.NativeFieldInfoPtr_timeSinceSighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "timeSinceSighted");
			VisionEvent.NativeFieldInfoPtr_currentNoticeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "currentNoticeTime");
			VisionEvent.NativeMethodInfoPtr_get_Target_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666819);
			VisionEvent.NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666820);
			VisionEvent.NativeMethodInfoPtr_get_State_Public_get_VisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666821);
			VisionEvent.NativeMethodInfoPtr_set_State_Protected_set_Void_VisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666822);
			VisionEvent.NativeMethodInfoPtr_get_Owner_Public_get_VisionCone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666823);
			VisionEvent.NativeMethodInfoPtr_set_Owner_Protected_set_Void_VisionCone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666824);
			VisionEvent.NativeMethodInfoPtr_get_FullNoticeTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666825);
			VisionEvent.NativeMethodInfoPtr_set_FullNoticeTime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666826);
			VisionEvent.NativeMethodInfoPtr_get_NormalizedNoticeLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666827);
			VisionEvent.NativeMethodInfoPtr__ctor_Public_Void_VisionCone_Player_VisualState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666828);
			VisionEvent.NativeMethodInfoPtr_UpdateEvent_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666829);
			VisionEvent.NativeMethodInfoPtr_EndEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666830);
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x000D3184 File Offset: 0x000D1384
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x000D31C4 File Offset: 0x000D13C4
		public unsafe Player Target
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 18697, RefRangeEnd = 18709, XrefRangeStart = 18697, XrefRangeEnd = 18709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_get_Target_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31460, RefRangeEnd = 31462, XrefRangeStart = 31460, XrefRangeEnd = 31462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x000D3208 File Offset: 0x000D1408
		// (set) Token: 0x06001EC1 RID: 7873 RVA: 0x000D3248 File Offset: 0x000D1448
		public unsafe PlayerVisualState.VisualState State
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_get_State_Public_get_VisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState.VisualState>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_set_State_Protected_set_Void_VisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x000D328C File Offset: 0x000D148C
		// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x000D32CC File Offset: 0x000D14CC
		public unsafe VisionCone Owner
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_get_Owner_Public_get_VisionCone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_set_Owner_Protected_set_Void_VisionCone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x000D3310 File Offset: 0x000D1510
		// (set) Token: 0x06001EC5 RID: 7877 RVA: 0x000D334C File Offset: 0x000D154C
		public unsafe float FullNoticeTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62417, RefRangeEnd = 62418, XrefRangeStart = 62417, XrefRangeEnd = 62418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_get_FullNoticeTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_set_FullNoticeTime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x000D338C File Offset: 0x000D158C
		public unsafe float NormalizedNoticeLevel
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110780, RefRangeEnd = 110783, XrefRangeStart = 110780, XrefRangeEnd = 110780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_get_NormalizedNoticeLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x000D33C8 File Offset: 0x000D15C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110801, RefRangeEnd = 110802, XrefRangeStart = 110783, XrefRangeEnd = 110801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionEvent(VisionCone _owner, Player _target, PlayerVisualState.VisualState _state, float _noticeTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_owner);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_target);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_state);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _noticeTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr__ctor_Public_Void_VisionCone_Player_VisualState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x000D3448 File Offset: 0x000D1648
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110818, RefRangeEnd = 110820, XrefRangeStart = 110802, XrefRangeEnd = 110818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEvent(float visionDeltaThisFrame, float tickTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref visionDeltaThisFrame;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref tickTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_UpdateEvent_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x000D3494 File Offset: 0x000D1694
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110822, RefRangeEnd = 110825, XrefRangeStart = 110820, XrefRangeEnd = 110822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_EndEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x000113ED File Offset: 0x0000F5ED
		public VisionEvent(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06001ECB RID: 7883 RVA: 0x000D34C8 File Offset: 0x000D16C8
		// (set) Token: 0x06001ECC RID: 7884 RVA: 0x000113F6 File Offset: 0x0000F5F6
		public unsafe static float NOTICE_DROP_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionEvent.NativeFieldInfoPtr_NOTICE_DROP_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionEvent.NativeFieldInfoPtr_NOTICE_DROP_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x000D34E4 File Offset: 0x000D16E4
		// (set) Token: 0x06001ECE RID: 7886 RVA: 0x00011404 File Offset: 0x0000F604
		public unsafe Player _Target_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__Target_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__Target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x000D3514 File Offset: 0x000D1714
		// (set) Token: 0x06001ED0 RID: 7888 RVA: 0x00011423 File Offset: 0x0000F623
		public unsafe PlayerVisualState.VisualState _State_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__State_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState.VisualState>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__State_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x000D3544 File Offset: 0x000D1744
		// (set) Token: 0x06001ED2 RID: 7890 RVA: 0x00011442 File Offset: 0x0000F642
		public unsafe VisionCone _Owner_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__Owner_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__Owner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x000D3574 File Offset: 0x000D1774
		// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x00011461 File Offset: 0x0000F661
		public unsafe float _FullNoticeTime_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__FullNoticeTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__FullNoticeTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x000D359C File Offset: 0x000D179C
		// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x0001147C File Offset: 0x0000F67C
		public unsafe float timeSinceSighted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr_timeSinceSighted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr_timeSinceSighted)) = value;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x000D35C4 File Offset: 0x000D17C4
		// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x00011497 File Offset: 0x0000F697
		public unsafe float currentNoticeTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr_currentNoticeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr_currentNoticeTime)) = value;
			}
		}

		// Token: 0x0400146E RID: 5230
		private static readonly System.IntPtr NativeFieldInfoPtr_NOTICE_DROP_THRESHOLD;

		// Token: 0x0400146F RID: 5231
		private static readonly System.IntPtr NativeFieldInfoPtr__Target_k__BackingField;

		// Token: 0x04001470 RID: 5232
		private static readonly System.IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04001471 RID: 5233
		private static readonly System.IntPtr NativeFieldInfoPtr__Owner_k__BackingField;

		// Token: 0x04001472 RID: 5234
		private static readonly System.IntPtr NativeFieldInfoPtr__FullNoticeTime_k__BackingField;

		// Token: 0x04001473 RID: 5235
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceSighted;

		// Token: 0x04001474 RID: 5236
		private static readonly System.IntPtr NativeFieldInfoPtr_currentNoticeTime;

		// Token: 0x04001475 RID: 5237
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Target_Public_get_Player_0;

		// Token: 0x04001476 RID: 5238
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0;

		// Token: 0x04001477 RID: 5239
		private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Public_get_VisualState_0;

		// Token: 0x04001478 RID: 5240
		private static readonly System.IntPtr NativeMethodInfoPtr_set_State_Protected_set_Void_VisualState_0;

		// Token: 0x04001479 RID: 5241
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Owner_Public_get_VisionCone_0;

		// Token: 0x0400147A RID: 5242
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Owner_Protected_set_Void_VisionCone_0;

		// Token: 0x0400147B RID: 5243
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FullNoticeTime_Public_get_Single_0;

		// Token: 0x0400147C RID: 5244
		private static readonly System.IntPtr NativeMethodInfoPtr_set_FullNoticeTime_Protected_set_Void_Single_0;

		// Token: 0x0400147D RID: 5245
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NormalizedNoticeLevel_Public_get_Single_0;

		// Token: 0x0400147E RID: 5246
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_VisionCone_Player_VisualState_Single_0;

		// Token: 0x0400147F RID: 5247
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEvent_Public_Void_Single_Single_0;

		// Token: 0x04001480 RID: 5248
		private static readonly System.IntPtr NativeMethodInfoPtr_EndEvent_Public_Void_0;
	}
}
