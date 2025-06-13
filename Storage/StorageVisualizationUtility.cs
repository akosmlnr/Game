using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200059E RID: 1438
	public static class StorageVisualizationUtility : Il2CppSystem.Object
	{
		// Token: 0x06007DA1 RID: 32161 RVA: 0x0003B591 File Offset: 0x00039791
		// Note: this type is marked as 'beforefieldinit'.
		static StorageVisualizationUtility()
		{
			Il2CppClassPointerStore<StorageVisualizationUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageVisualizationUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageVisualizationUtility>.NativeClassPtr);
			StorageVisualizationUtility.NativeMethodInfoPtr_GetVisualRepresentation_Public_Static_Dictionary_2_StorableItemInstance_Int32_Dictionary_2_StorableItemInstance_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizationUtility>.NativeClassPtr, 100679147);
		}

		// Token: 0x06007DA2 RID: 32162 RVA: 0x0021EF44 File Offset: 0x0021D144
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 240216, RefRangeEnd = 240218, XrefRangeStart = 240152, XrefRangeEnd = 240216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<StorableItemInstance, int> GetVisualRepresentation(Dictionary<StorableItemInstance, int> inputDictionary, int TotalFootprintSize)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDictionary);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref TotalFootprintSize;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizationUtility.NativeMethodInfoPtr_GetVisualRepresentation_Public_Static_Dictionary_2_StorableItemInstance_Int32_Dictionary_2_StorableItemInstance_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StorableItemInstance, int>>(intPtr2) : null;
		}

		// Token: 0x06007DA3 RID: 32163 RVA: 0x0003B5CA File Offset: 0x000397CA
		public StorageVisualizationUtility(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005594 RID: 21908
		private static readonly System.IntPtr NativeMethodInfoPtr_GetVisualRepresentation_Public_Static_Dictionary_2_StorableItemInstance_Int32_Dictionary_2_StorableItemInstance_Int32_Int32_0;
	}
}
