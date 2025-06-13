using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Misc;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003D7 RID: 983
	public class LightTimer : MonoBehaviour
	{
		// Token: 0x06004B82 RID: 19330 RVA: 0x001703B4 File Offset: 0x0016E5B4
		// Note: this type is marked as 'beforefieldinit'.
		static LightTimer()
		{
			Il2CppClassPointerStore<LightTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "LightTimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightTimer>.NativeClassPtr);
			LightTimer.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "StartTime");
			LightTimer.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "EndTime");
			LightTimer.NativeFieldInfoPtr_StartTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "StartTimeOffset");
			LightTimer.NativeFieldInfoPtr_toggleableLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "toggleableLight");
			LightTimer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672740);
			LightTimer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672741);
			LightTimer.NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672742);
			LightTimer.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672743);
			LightTimer.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672744);
			LightTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672745);
		}

		// Token: 0x06004B83 RID: 19331 RVA: 0x001704AC File Offset: 0x0016E6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168303, XrefRangeEnd = 168323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightTimer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x001704E8 File Offset: 0x0016E6E8
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x0017051C File Offset: 0x0016E71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168323, XrefRangeEnd = 168328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightTimer.NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B86 RID: 19334 RVA: 0x00170558 File Offset: 0x0016E758
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B87 RID: 19335 RVA: 0x0017058C File Offset: 0x0016E78C
		[CallerCount(0)]
		public unsafe void SetState(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B88 RID: 19336 RVA: 0x001705CC File Offset: 0x0016E7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightTimer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightTimer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x00024330 File Offset: 0x00022530
		public LightTimer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06004B8A RID: 19338 RVA: 0x00170608 File Offset: 0x0016E808
		// (set) Token: 0x06004B8B RID: 19339 RVA: 0x00024339 File Offset: 0x00022539
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06004B8C RID: 19340 RVA: 0x00170630 File Offset: 0x0016E830
		// (set) Token: 0x06004B8D RID: 19341 RVA: 0x00024354 File Offset: 0x00022554
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06004B8E RID: 19342 RVA: 0x00170658 File Offset: 0x0016E858
		// (set) Token: 0x06004B8F RID: 19343 RVA: 0x0002436F File Offset: 0x0002256F
		public unsafe int StartTimeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTimeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTimeOffset)) = value;
			}
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x06004B90 RID: 19344 RVA: 0x00170680 File Offset: 0x0016E880
		// (set) Token: 0x06004B91 RID: 19345 RVA: 0x0002438A File Offset: 0x0002258A
		public unsafe ToggleableLight toggleableLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_toggleableLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_toggleableLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032DF RID: 13023
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x040032E0 RID: 13024
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x040032E1 RID: 13025
		private static readonly IntPtr NativeFieldInfoPtr_StartTimeOffset;

		// Token: 0x040032E2 RID: 13026
		private static readonly IntPtr NativeFieldInfoPtr_toggleableLight;

		// Token: 0x040032E3 RID: 13027
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040032E4 RID: 13028
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040032E5 RID: 13029
		private static readonly IntPtr NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0;

		// Token: 0x040032E6 RID: 13030
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040032E7 RID: 13031
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Private_Void_Boolean_0;

		// Token: 0x040032E8 RID: 13032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
