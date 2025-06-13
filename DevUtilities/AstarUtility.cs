using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000470 RID: 1136
	public class AstarUtility : MonoBehaviour
	{
		// Token: 0x060061A8 RID: 25000 RVA: 0x001C1A30 File Offset: 0x001BFC30
		// Note: this type is marked as 'beforefieldinit'.
		static AstarUtility()
		{
			Il2CppClassPointerStore<AstarUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AstarUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr);
			AstarUtility.NativeMethodInfoPtr_GetClosestPointOnGraph_Public_Static_Vector3_Vector3_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr, 100675849);
			AstarUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr, 100675850);
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x001C1A88 File Offset: 0x001BFC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203217, XrefRangeEnd = 203227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnGraph(Vector3 point, string GraphName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GraphName);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AstarUtility.NativeMethodInfoPtr_GetClosestPointOnGraph_Public_Static_Vector3_Vector3_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x001C1AD8 File Offset: 0x001BFCD8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstarUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AstarUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061AB RID: 25003 RVA: 0x0002DD7B File Offset: 0x0002BF7B
		public AstarUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040042BD RID: 17085
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnGraph_Public_Static_Vector3_Vector3_String_0;

		// Token: 0x040042BE RID: 17086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
