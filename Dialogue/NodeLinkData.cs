using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200046B RID: 1131
	[System.Serializable]
	public class NodeLinkData : Il2CppSystem.Object
	{
		// Token: 0x0600618C RID: 24972 RVA: 0x001C15CC File Offset: 0x001BF7CC
		// Note: this type is marked as 'beforefieldinit'.
		static NodeLinkData()
		{
			Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "NodeLinkData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr);
			NodeLinkData.NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, "BaseDialogueOrBranchNodeGuid");
			NodeLinkData.NativeFieldInfoPtr_BaseChoiceOrOptionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, "BaseChoiceOrOptionGUID");
			NodeLinkData.NativeFieldInfoPtr_TargetNodeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, "TargetNodeGuid");
			NodeLinkData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, 100675838);
		}

		// Token: 0x0600618D RID: 24973 RVA: 0x001C164C File Offset: 0x001BF84C
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodeLinkData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeLinkData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600618E RID: 24974 RVA: 0x0002DC7E File Offset: 0x0002BE7E
		public NodeLinkData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x0600618F RID: 24975 RVA: 0x001C1688 File Offset: 0x001BF888
		// (set) Token: 0x06006190 RID: 24976 RVA: 0x0002DC87 File Offset: 0x0002BE87
		public unsafe string BaseDialogueOrBranchNodeGuid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x06006191 RID: 24977 RVA: 0x001C16B0 File Offset: 0x001BF8B0
		// (set) Token: 0x06006192 RID: 24978 RVA: 0x0002DCA6 File Offset: 0x0002BEA6
		public unsafe string BaseChoiceOrOptionGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseChoiceOrOptionGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseChoiceOrOptionGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x06006193 RID: 24979 RVA: 0x001C16D8 File Offset: 0x001BF8D8
		// (set) Token: 0x06006194 RID: 24980 RVA: 0x0002DCC5 File Offset: 0x0002BEC5
		public unsafe string TargetNodeGuid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_TargetNodeGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_TargetNodeGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040042B0 RID: 17072
		private static readonly System.IntPtr NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid;

		// Token: 0x040042B1 RID: 17073
		private static readonly System.IntPtr NativeFieldInfoPtr_BaseChoiceOrOptionGUID;

		// Token: 0x040042B2 RID: 17074
		private static readonly System.IntPtr NativeFieldInfoPtr_TargetNodeGuid;

		// Token: 0x040042B3 RID: 17075
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
