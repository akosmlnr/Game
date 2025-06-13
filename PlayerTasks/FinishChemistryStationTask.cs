using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000217 RID: 535
	public class FinishChemistryStationTask : Task
	{
		// Token: 0x06002BF9 RID: 11257 RVA: 0x00017B39 File Offset: 0x00015D39
		// Note: this type is marked as 'beforefieldinit'.
		static FinishChemistryStationTask()
		{
			Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "FinishChemistryStationTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr);
			FinishChemistryStationTask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr, 100668276);
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x000FE9EC File Offset: 0x000FCBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125242, XrefRangeEnd = 125243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FinishChemistryStationTask() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishChemistryStationTask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x00017B72 File Offset: 0x00015D72
		public FinishChemistryStationTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001D27 RID: 7463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
