using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.Tiles;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000471 RID: 1137
	public class Autotest : MonoBehaviour
	{
		// Token: 0x060061AC RID: 25004 RVA: 0x001C1B14 File Offset: 0x001BFD14
		// Note: this type is marked as 'beforefieldinit'.
		static Autotest()
		{
			Il2CppClassPointerStore<Autotest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "Autotest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Autotest>.NativeClassPtr);
			Autotest.NativeFieldInfoPtr_workerAccom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Autotest>.NativeClassPtr, "workerAccom");
			Autotest.NativeFieldInfoPtr_crescentGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Autotest>.NativeClassPtr, "crescentGrid");
			Autotest.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Autotest>.NativeClassPtr, 100675851);
			Autotest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Autotest>.NativeClassPtr, 100675852);
		}

		// Token: 0x060061AD RID: 25005 RVA: 0x001C1B94 File Offset: 0x001BFD94
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Autotest.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061AE RID: 25006 RVA: 0x001C1BC8 File Offset: 0x001BFDC8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Autotest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Autotest>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Autotest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061AF RID: 25007 RVA: 0x0002DD84 File Offset: 0x0002BF84
		public Autotest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x060061B0 RID: 25008 RVA: 0x001C1C04 File Offset: 0x001BFE04
		// (set) Token: 0x060061B1 RID: 25009 RVA: 0x0002DD8D File Offset: 0x0002BF8D
		public unsafe Constructable_GridBased workerAccom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Autotest.NativeFieldInfoPtr_workerAccom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Autotest.NativeFieldInfoPtr_workerAccom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x060061B2 RID: 25010 RVA: 0x001C1C34 File Offset: 0x001BFE34
		// (set) Token: 0x060061B3 RID: 25011 RVA: 0x0002DDAC File Offset: 0x0002BFAC
		public unsafe Grid crescentGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Autotest.NativeFieldInfoPtr_crescentGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Autotest.NativeFieldInfoPtr_crescentGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042BF RID: 17087
		private static readonly IntPtr NativeFieldInfoPtr_workerAccom;

		// Token: 0x040042C0 RID: 17088
		private static readonly IntPtr NativeFieldInfoPtr_crescentGrid;

		// Token: 0x040042C1 RID: 17089
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x040042C2 RID: 17090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
