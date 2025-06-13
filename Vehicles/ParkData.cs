using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x02000506 RID: 1286
	[System.Serializable]
	public class ParkData : Il2CppSystem.Object
	{
		// Token: 0x060070AA RID: 28842 RVA: 0x001F40EC File Offset: 0x001F22EC
		// Note: this type is marked as 'beforefieldinit'.
		static ParkData()
		{
			Il2CppClassPointerStore<ParkData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "ParkData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkData>.NativeClassPtr);
			ParkData.NativeFieldInfoPtr_lotGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkData>.NativeClassPtr, "lotGUID");
			ParkData.NativeFieldInfoPtr_spotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkData>.NativeClassPtr, "spotIndex");
			ParkData.NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkData>.NativeClassPtr, "alignment");
			ParkData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkData>.NativeClassPtr, 100677641);
		}

		// Token: 0x060070AB RID: 28843 RVA: 0x001F416C File Offset: 0x001F236C
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070AC RID: 28844 RVA: 0x00035109 File Offset: 0x00033309
		public ParkData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021C4 RID: 8644
		// (get) Token: 0x060070AD RID: 28845 RVA: 0x001F41A8 File Offset: 0x001F23A8
		// (set) Token: 0x060070AE RID: 28846 RVA: 0x00035112 File Offset: 0x00033312
		public unsafe Il2CppSystem.Guid lotGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_lotGUID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_lotGUID)) = value;
			}
		}

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x060070AF RID: 28847 RVA: 0x001F41D0 File Offset: 0x001F23D0
		// (set) Token: 0x060070B0 RID: 28848 RVA: 0x0003512D File Offset: 0x0003332D
		public unsafe int spotIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_spotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_spotIndex)) = value;
			}
		}

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x060070B1 RID: 28849 RVA: 0x001F41F8 File Offset: 0x001F23F8
		// (set) Token: 0x060070B2 RID: 28850 RVA: 0x00035148 File Offset: 0x00033348
		public unsafe EParkingAlignment alignment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_alignment)) = value;
			}
		}

		// Token: 0x04004D1A RID: 19738
		private static readonly System.IntPtr NativeFieldInfoPtr_lotGUID;

		// Token: 0x04004D1B RID: 19739
		private static readonly System.IntPtr NativeFieldInfoPtr_spotIndex;

		// Token: 0x04004D1C RID: 19740
		private static readonly System.IntPtr NativeFieldInfoPtr_alignment;

		// Token: 0x04004D1D RID: 19741
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
