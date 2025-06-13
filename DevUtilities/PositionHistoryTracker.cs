using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200048A RID: 1162
	public class PositionHistoryTracker : MonoBehaviour
	{
		// Token: 0x060063AB RID: 25515 RVA: 0x001C7EAC File Offset: 0x001C60AC
		// Note: this type is marked as 'beforefieldinit'.
		static PositionHistoryTracker()
		{
			Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PositionHistoryTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr);
			PositionHistoryTracker.NativeFieldInfoPtr_recordingFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "recordingFrequency");
			PositionHistoryTracker.NativeFieldInfoPtr_historyDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "historyDuration");
			PositionHistoryTracker.NativeFieldInfoPtr_positionHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "positionHistory");
			PositionHistoryTracker.NativeFieldInfoPtr_lastRecordTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "lastRecordTime");
			PositionHistoryTracker.NativeMethodInfoPtr_get_RecordedTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100676052);
			PositionHistoryTracker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100676053);
			PositionHistoryTracker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100676054);
			PositionHistoryTracker.NativeMethodInfoPtr_RecordPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100676055);
			PositionHistoryTracker.NativeMethodInfoPtr_GetPositionXSecondsAgo_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100676056);
			PositionHistoryTracker.NativeMethodInfoPtr_ClearHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100676057);
			PositionHistoryTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100676058);
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x060063AC RID: 25516 RVA: 0x001C7FB8 File Offset: 0x001C61B8
		public unsafe float RecordedTime
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 205852, RefRangeEnd = 205854, XrefRangeStart = 205851, XrefRangeEnd = 205852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_get_RecordedTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x001C7FF4 File Offset: 0x001C61F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205854, XrefRangeEnd = 205855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063AE RID: 25518 RVA: 0x001C8028 File Offset: 0x001C6228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205855, XrefRangeEnd = 205867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063AF RID: 25519 RVA: 0x001C805C File Offset: 0x001C625C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205867, XrefRangeEnd = 205877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_RecordPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x001C8090 File Offset: 0x001C6290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205882, RefRangeEnd = 205884, XrefRangeStart = 205877, XrefRangeEnd = 205882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPositionXSecondsAgo(float secondsAgo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref secondsAgo;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_GetPositionXSecondsAgo_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060063B1 RID: 25521 RVA: 0x001C80DC File Offset: 0x001C62DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205885, RefRangeEnd = 205886, XrefRangeStart = 205884, XrefRangeEnd = 205885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_ClearHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063B2 RID: 25522 RVA: 0x001C8110 File Offset: 0x001C6310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205886, XrefRangeEnd = 205894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PositionHistoryTracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063B3 RID: 25523 RVA: 0x0002EDDB File Offset: 0x0002CFDB
		public PositionHistoryTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x060063B4 RID: 25524 RVA: 0x001C814C File Offset: 0x001C634C
		// (set) Token: 0x060063B5 RID: 25525 RVA: 0x0002EDE4 File Offset: 0x0002CFE4
		public unsafe float recordingFrequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_recordingFrequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_recordingFrequency)) = value;
			}
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x060063B6 RID: 25526 RVA: 0x001C8174 File Offset: 0x001C6374
		// (set) Token: 0x060063B7 RID: 25527 RVA: 0x0002EDFF File Offset: 0x0002CFFF
		public unsafe float historyDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_historyDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_historyDuration)) = value;
			}
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x060063B8 RID: 25528 RVA: 0x001C819C File Offset: 0x001C639C
		// (set) Token: 0x060063B9 RID: 25529 RVA: 0x0002EE1A File Offset: 0x0002D01A
		public unsafe List<Vector3> positionHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_positionHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_positionHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x060063BA RID: 25530 RVA: 0x001C81CC File Offset: 0x001C63CC
		// (set) Token: 0x060063BB RID: 25531 RVA: 0x0002EE39 File Offset: 0x0002D039
		public unsafe float lastRecordTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_lastRecordTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_lastRecordTime)) = value;
			}
		}

		// Token: 0x040043FE RID: 17406
		private static readonly IntPtr NativeFieldInfoPtr_recordingFrequency;

		// Token: 0x040043FF RID: 17407
		private static readonly IntPtr NativeFieldInfoPtr_historyDuration;

		// Token: 0x04004400 RID: 17408
		private static readonly IntPtr NativeFieldInfoPtr_positionHistory;

		// Token: 0x04004401 RID: 17409
		private static readonly IntPtr NativeFieldInfoPtr_lastRecordTime;

		// Token: 0x04004402 RID: 17410
		private static readonly IntPtr NativeMethodInfoPtr_get_RecordedTime_Public_get_Single_0;

		// Token: 0x04004403 RID: 17411
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004404 RID: 17412
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004405 RID: 17413
		private static readonly IntPtr NativeMethodInfoPtr_RecordPosition_Private_Void_0;

		// Token: 0x04004406 RID: 17414
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionXSecondsAgo_Public_Vector3_Single_0;

		// Token: 0x04004407 RID: 17415
		private static readonly IntPtr NativeMethodInfoPtr_ClearHistory_Public_Void_0;

		// Token: 0x04004408 RID: 17416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
