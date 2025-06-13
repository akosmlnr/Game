using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x02000508 RID: 1288
	public class SpeedZone : MonoBehaviour
	{
		// Token: 0x060070C5 RID: 28869 RVA: 0x001F4500 File Offset: 0x001F2700
		// Note: this type is marked as 'beforefieldinit'.
		static SpeedZone()
		{
			Il2CppClassPointerStore<SpeedZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "SpeedZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr);
			SpeedZone.NativeFieldInfoPtr_speedZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, "speedZones");
			SpeedZone.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, "col");
			SpeedZone.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, "speed");
			SpeedZone.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100677646);
			SpeedZone.NativeMethodInfoPtr_GetSpeedZones_Public_Static_List_1_SpeedZone_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100677647);
			SpeedZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100677648);
			SpeedZone.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100677649);
			SpeedZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100677650);
		}

		// Token: 0x060070C6 RID: 28870 RVA: 0x001F45D0 File Offset: 0x001F27D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224424, XrefRangeEnd = 224434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpeedZone.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070C7 RID: 28871 RVA: 0x001F460C File Offset: 0x001F280C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224434, XrefRangeEnd = 224461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<SpeedZone> GetSpeedZones(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedZone.NativeMethodInfoPtr_GetSpeedZones_Public_Static_List_1_SpeedZone_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpeedZone>>(intPtr2) : null;
		}

		// Token: 0x060070C8 RID: 28872 RVA: 0x001F464C File Offset: 0x001F284C
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070C9 RID: 28873 RVA: 0x001F4680 File Offset: 0x001F2880
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedZone.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070CA RID: 28874 RVA: 0x001F46B4 File Offset: 0x001F28B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224461, XrefRangeEnd = 224462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpeedZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070CB RID: 28875 RVA: 0x00035216 File Offset: 0x00033416
		public SpeedZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021CD RID: 8653
		// (get) Token: 0x060070CC RID: 28876 RVA: 0x001F46F0 File Offset: 0x001F28F0
		// (set) Token: 0x060070CD RID: 28877 RVA: 0x0003521F File Offset: 0x0003341F
		public unsafe static List<SpeedZone> speedZones
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpeedZone.NativeFieldInfoPtr_speedZones, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpeedZone>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpeedZone.NativeFieldInfoPtr_speedZones, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x060070CE RID: 28878 RVA: 0x001F4718 File Offset: 0x001F2918
		// (set) Token: 0x060070CF RID: 28879 RVA: 0x00035231 File Offset: 0x00033431
		public unsafe BoxCollider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x060070D0 RID: 28880 RVA: 0x001F4748 File Offset: 0x001F2948
		// (set) Token: 0x060070D1 RID: 28881 RVA: 0x00035250 File Offset: 0x00033450
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x04004D28 RID: 19752
		private static readonly IntPtr NativeFieldInfoPtr_speedZones;

		// Token: 0x04004D29 RID: 19753
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04004D2A RID: 19754
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04004D2B RID: 19755
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0;

		// Token: 0x04004D2C RID: 19756
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedZones_Public_Static_List_1_SpeedZone_Vector3_0;

		// Token: 0x04004D2D RID: 19757
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04004D2E RID: 19758
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x04004D2F RID: 19759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
