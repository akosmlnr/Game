using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000524 RID: 1316
	public class PathGroup : Il2CppSystem.Object
	{
		// Token: 0x060072F5 RID: 29429 RVA: 0x001FAA1C File Offset: 0x001F8C1C
		// Note: this type is marked as 'beforefieldinit'.
		static PathGroup()
		{
			Il2CppClassPointerStore<PathGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "PathGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathGroup>.NativeClassPtr);
			PathGroup.NativeFieldInfoPtr_entryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "entryPoint");
			PathGroup.NativeFieldInfoPtr_startToEntryPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "startToEntryPath");
			PathGroup.NativeFieldInfoPtr_entryToExitPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "entryToExitPath");
			PathGroup.NativeFieldInfoPtr_exitToDestinationPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "exitToDestinationPath");
			PathGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, 100677856);
		}

		// Token: 0x060072F6 RID: 29430 RVA: 0x001FAAB0 File Offset: 0x001F8CB0
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathGroup>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072F7 RID: 29431 RVA: 0x000365A6 File Offset: 0x000347A6
		public PathGroup(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x060072F8 RID: 29432 RVA: 0x001FAAEC File Offset: 0x001F8CEC
		// (set) Token: 0x060072F9 RID: 29433 RVA: 0x000365AF File Offset: 0x000347AF
		public unsafe Vector3 entryPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryPoint)) = value;
			}
		}

		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x060072FA RID: 29434 RVA: 0x001FAB14 File Offset: 0x001F8D14
		// (set) Token: 0x060072FB RID: 29435 RVA: 0x000365CA File Offset: 0x000347CA
		public unsafe Path startToEntryPath
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_startToEntryPath);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_startToEntryPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x060072FC RID: 29436 RVA: 0x001FAB44 File Offset: 0x001F8D44
		// (set) Token: 0x060072FD RID: 29437 RVA: 0x000365E9 File Offset: 0x000347E9
		public unsafe Path entryToExitPath
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryToExitPath);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryToExitPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x060072FE RID: 29438 RVA: 0x001FAB74 File Offset: 0x001F8D74
		// (set) Token: 0x060072FF RID: 29439 RVA: 0x00036608 File Offset: 0x00034808
		public unsafe Path exitToDestinationPath
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_exitToDestinationPath);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_exitToDestinationPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E88 RID: 20104
		private static readonly System.IntPtr NativeFieldInfoPtr_entryPoint;

		// Token: 0x04004E89 RID: 20105
		private static readonly System.IntPtr NativeFieldInfoPtr_startToEntryPath;

		// Token: 0x04004E8A RID: 20106
		private static readonly System.IntPtr NativeFieldInfoPtr_entryToExitPath;

		// Token: 0x04004E8B RID: 20107
		private static readonly System.IntPtr NativeFieldInfoPtr_exitToDestinationPath;

		// Token: 0x04004E8C RID: 20108
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
