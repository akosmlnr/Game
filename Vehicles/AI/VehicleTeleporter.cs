using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x0200052B RID: 1323
	public class VehicleTeleporter : MonoBehaviour
	{
		// Token: 0x0600741A RID: 29722 RVA: 0x001FDBC4 File Offset: 0x001FBDC4
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleTeleporter()
		{
			Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "VehicleTeleporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr);
			VehicleTeleporter.NativeMethodInfoPtr_MoveToGraph_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr, 100677940);
			VehicleTeleporter.NativeMethodInfoPtr_MoveToRoadNetwork_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr, 100677941);
			VehicleTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr, 100677942);
		}

		// Token: 0x0600741B RID: 29723 RVA: 0x001FDC30 File Offset: 0x001FBE30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227591, RefRangeEnd = 227592, XrefRangeStart = 227565, XrefRangeEnd = 227591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToGraph(bool resetRotation = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetRotation;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleTeleporter.NativeMethodInfoPtr_MoveToGraph_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600741C RID: 29724 RVA: 0x001FDC70 File Offset: 0x001FBE70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227618, RefRangeEnd = 227619, XrefRangeStart = 227592, XrefRangeEnd = 227618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToRoadNetwork(bool resetRotation = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetRotation;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleTeleporter.NativeMethodInfoPtr_MoveToRoadNetwork_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600741D RID: 29725 RVA: 0x001FDCB0 File Offset: 0x001FBEB0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleTeleporter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600741E RID: 29726 RVA: 0x0003708E File Offset: 0x0003528E
		public VehicleTeleporter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004F3A RID: 20282
		private static readonly IntPtr NativeMethodInfoPtr_MoveToGraph_Public_Void_Boolean_0;

		// Token: 0x04004F3B RID: 20283
		private static readonly IntPtr NativeMethodInfoPtr_MoveToRoadNetwork_Public_Void_Boolean_0;

		// Token: 0x04004F3C RID: 20284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
