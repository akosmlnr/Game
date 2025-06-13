using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C2 RID: 450
	public class Quest_Connections : Quest
	{
		// Token: 0x06002692 RID: 9874 RVA: 0x000EC9D0 File Offset: 0x000EABD0
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Connections()
		{
			Il2CppClassPointerStore<Quest_Connections>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Connections");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Connections>.NativeClassPtr);
			Quest_Connections.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Connections>.NativeClassPtr, 100667652);
			Quest_Connections.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Connections>.NativeClassPtr, 100667653);
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x000ECA28 File Offset: 0x000EAC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120050, XrefRangeEnd = 120069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Connections.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x000ECA74 File Offset: 0x000EAC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120069, XrefRangeEnd = 120073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Connections() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Connections>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Connections.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x000154CA File Offset: 0x000136CA
		public Quest_Connections(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
