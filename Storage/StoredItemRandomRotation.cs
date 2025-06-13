using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x020005A2 RID: 1442
	public class StoredItemRandomRotation : MonoBehaviour
	{
		// Token: 0x06007E0C RID: 32268 RVA: 0x0022063C File Offset: 0x0021E83C
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItemRandomRotation()
		{
			Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StoredItemRandomRotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr);
			StoredItemRandomRotation.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr, "ItemContainer");
			StoredItemRandomRotation.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr, 100679201);
			StoredItemRandomRotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr, 100679202);
		}

		// Token: 0x06007E0D RID: 32269 RVA: 0x002206A8 File Offset: 0x0021E8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240910, XrefRangeEnd = 240914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItemRandomRotation.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E0E RID: 32270 RVA: 0x002206DC File Offset: 0x0021E8DC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItemRandomRotation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItemRandomRotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E0F RID: 32271 RVA: 0x0003B8DB File Offset: 0x00039ADB
		public StoredItemRandomRotation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025E0 RID: 9696
		// (get) Token: 0x06007E10 RID: 32272 RVA: 0x00220718 File Offset: 0x0021E918
		// (set) Token: 0x06007E11 RID: 32273 RVA: 0x0003B8E4 File Offset: 0x00039AE4
		public unsafe Transform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItemRandomRotation.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItemRandomRotation.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040055DD RID: 21981
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x040055DE RID: 21982
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040055DF RID: 21983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
