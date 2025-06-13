using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000599 RID: 1433
	public class StorageEntityVisualizer : StorageVisualizer
	{
		// Token: 0x06007D45 RID: 32069 RVA: 0x0021DAE8 File Offset: 0x0021BCE8
		// Note: this type is marked as 'beforefieldinit'.
		static StorageEntityVisualizer()
		{
			Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageEntityVisualizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr);
			StorageEntityVisualizer.NativeFieldInfoPtr_storageEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr, "storageEntity");
			StorageEntityVisualizer.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr, 100679105);
			StorageEntityVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr, 100679106);
		}

		// Token: 0x06007D46 RID: 32070 RVA: 0x0021DB54 File Offset: 0x0021BD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239769, XrefRangeEnd = 239787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageEntityVisualizer.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D47 RID: 32071 RVA: 0x0021DB90 File Offset: 0x0021BD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239787, XrefRangeEnd = 239802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageEntityVisualizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageEntityVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D48 RID: 32072 RVA: 0x0003B30B File Offset: 0x0003950B
		public StorageEntityVisualizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700259E RID: 9630
		// (get) Token: 0x06007D49 RID: 32073 RVA: 0x0021DBCC File Offset: 0x0021BDCC
		// (set) Token: 0x06007D4A RID: 32074 RVA: 0x0003B314 File Offset: 0x00039514
		public unsafe StorageEntity storageEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityVisualizer.NativeFieldInfoPtr_storageEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityVisualizer.NativeFieldInfoPtr_storageEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005557 RID: 21847
		private static readonly IntPtr NativeFieldInfoPtr_storageEntity;

		// Token: 0x04005558 RID: 21848
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04005559 RID: 21849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
