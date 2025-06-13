using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x02000515 RID: 1301
	public class VehicleSeat : MonoBehaviour
	{
		// Token: 0x060071E7 RID: 29159 RVA: 0x001F7C90 File Offset: 0x001F5E90
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSeat()
		{
			Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleSeat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr);
			VehicleSeat.NativeFieldInfoPtr_isDriverSeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, "isDriverSeat");
			VehicleSeat.NativeFieldInfoPtr_Occupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, "Occupant");
			VehicleSeat.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, 100677747);
			VehicleSeat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, 100677748);
		}

		// Token: 0x1700222D RID: 8749
		// (get) Token: 0x060071E8 RID: 29160 RVA: 0x001F7D10 File Offset: 0x001F5F10
		public unsafe bool isOccupied
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 225365, RefRangeEnd = 225367, XrefRangeStart = 225361, XrefRangeEnd = 225365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleSeat.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x001F7D4C File Offset: 0x001F5F4C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSeat() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSeat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060071EA RID: 29162 RVA: 0x00035BAE File Offset: 0x00033DAE
		public VehicleSeat(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x060071EB RID: 29163 RVA: 0x001F7D88 File Offset: 0x001F5F88
		// (set) Token: 0x060071EC RID: 29164 RVA: 0x00035BB7 File Offset: 0x00033DB7
		public unsafe bool isDriverSeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_isDriverSeat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_isDriverSeat)) = value;
			}
		}

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x060071ED RID: 29165 RVA: 0x001F7DB0 File Offset: 0x001F5FB0
		// (set) Token: 0x060071EE RID: 29166 RVA: 0x00035BD2 File Offset: 0x00033DD2
		public unsafe Player Occupant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_Occupant);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_Occupant), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004DDC RID: 19932
		private static readonly IntPtr NativeFieldInfoPtr_isDriverSeat;

		// Token: 0x04004DDD RID: 19933
		private static readonly IntPtr NativeFieldInfoPtr_Occupant;

		// Token: 0x04004DDE RID: 19934
		private static readonly IntPtr NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0;

		// Token: 0x04004DDF RID: 19935
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
